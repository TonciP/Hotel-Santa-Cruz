import axios from 'axios';
import React, { useEffect, useState } from 'react'
import { Card, Col, Form, Row } from 'react-bootstrap';
import { useSelector } from 'react-redux';
import { useHistory } from 'react-router';

const FormCheckin = (props) => {
    const token = useSelector(state => state.login.token)

    const { id } = props.match ? props.match.params : { id: 0 };
    const history = useHistory();

    const [reservaId, setReservaId] = useState('');
    const [creditCardId, setCreditCardId] = useState('');
    const [tipoTarjeta, setTipotarjeta] = useState('');
    const [numeroTarjeta, setNumeroTarjeta] = useState(0);
    const [habitacionId, setHabitacionId] = useState(0);
    const [huespedId, setHuespedId] = useState('');
    const [dni, setDni] = useState('');
    const [clienteId, setClienteId] = useState('');
    const [habitacion, setHabitacion] = useState([]);




    useEffect(() => {
        fetchDatosHabitacion();
    }, []);
    const fetchDatosHabitacion = () => {

        const url = 'https://localhost:7272/api/Habitacion/search';
        axios.get(url
        )
            .then((response) => {
                console.log('fetchDatosHabitacion', response.data);
                const objProducto = response.data;
                console.log('objProducto', objProducto);
                setHabitacion(objProducto);

            }).catch(error => {
                // console.log('error', error);
                if (error.response.status === 401) {
                    history.push('/login');
                }
            });
    }

    const enviarDatos = () => {
        const params = {
            "reservaId": reservaId,
            "creditCard": {
                "creditCardId": creditCardId,
                "tipoTarjeta": tipoTarjeta,
                "numeroTarjeta": numeroTarjeta
            },
            "habitacionId": habitacionId,
            "huesped": {
                "huespedId": huespedId,
                "dni": dni
            },
            "clienteId": clienteId
        };
        insertarCheckin(params);
    }
    const insertarCheckin = (params) => {

        const url = 'https://localhost:7272/api/CheckIn';
        axios.post(url, params, {
            headers: {
                "Authorization": "Bearer " + token
            }
        }
        ).then(response => {

            console.log('recibido', response.data);
            alert(response.data)
        }).catch(error => {
            console.log(error);
            alert(error)


            if (error.response.status === 401) {
                history.push('/habitacion');
            }
        });
    }
    return (
        <Row className="mt-3">
            <Col md={{ span: 6, offset: 3 }}>
                <Card className="mt-3">

                    <Card.Body>
                        <Card.Title>Hacer de CheckIn</Card.Title>

                        <div><label>Reserva:</label></div>
                        <div><input className="form-control" type="text" value={reservaId} onChange={(e) => {
                            setReservaId(e.target.value);
                        }} /></div>

                        <div><label>Credit Card:</label></div>
                        <div><input className="form-control" type="text" value={creditCardId} onChange={(e) => {
                            setCreditCardId(e.target.value);
                        }} /></div>

                        <div><label>Tipo Tarjeta:</label></div>
                        <div><input className="form-control" type="text" value={tipoTarjeta} onChange={(e) => {
                            setTipotarjeta(e.target.value);
                        }} /></div>

                        <div><label>Numero Tarjeta:</label></div>
                        <div><input className="form-control" type="text" value={numeroTarjeta} onChange={(e) => {
                            setNumeroTarjeta(e.target.value);
                        }} /></div>

                        <div><label>Habitacion:</label></div>
                        <select name="habitacion" className='form-control' onChange={(e) => {
                            setHabitacionId(e.target.value);
                        }}>
                            {habitacion.map(elemento => (
                                <option key={elemento.id} value={elemento.habitacionId}>{elemento.habitacionId}</option>
                            )
                            )}
                        </select>

                        <div><label>Huesped:</label></div>
                        <div><input className="form-control" type="text" value={huespedId} onChange={(e) => {
                            setHuespedId(e.target.value);
                        }} /></div>

                        <div><label>Dni:</label></div>
                        <div><input className="form-control" type="text" value={dni} onChange={(e) => {
                            setDni(e.target.value);
                        }} /></div>

                        <div><label>Cliente:</label></div>
                        <div><input className="form-control" type="text" value={clienteId} onChange={(e) => {
                            setClienteId(e.target.value);
                        }} /></div>

                        <button className="btn btn-primary mt-3" onClick={enviarDatos}>
                            Guardar
                        </button>
                    </Card.Body>
                </Card>
            </Col>
        </Row>
    );
}

export default FormCheckin;