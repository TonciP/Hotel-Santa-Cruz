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



    useEffect(() => {

    }, []);


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

        const url = 'https://localhost:7098/api/CheckIn';
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
                history.push('/login');
            }
        });
    }
    return (
        <Row className="mt-3">
            <Col md={{ span: 6, offset: 3 }}>
                <Card className="mt-3">

                    <Card.Body>
                        <Card.Title>Hacer de CheckIn</Card.Title>

                        <div><label>reservaId:</label></div>
                        <div><input className="form-control" type="text" value={reservaId} onChange={(e) => {
                            setReservaId(e.target.value);
                        }} /></div>

                        <div><label>creditCardId:</label></div>
                        <div><input className="form-control" type="text" value={creditCardId} onChange={(e) => {
                            setCreditCardId(e.target.value);
                        }} /></div>

                        <div><label>tipoTarjeta:</label></div>
                        <div><input className="form-control" type="text" value={tipoTarjeta} onChange={(e) => {
                            setTipotarjeta(e.target.value);
                        }} /></div>

                        <div><label>numeroTarjeta:</label></div>
                        <div><input className="form-control" type="text" value={numeroTarjeta} onChange={(e) => {
                            setNumeroTarjeta(e.target.value);
                        }} /></div>

                        <div><label>habitacionId:</label></div>
                        <div><input className="form-control" type="text" value={habitacionId} onChange={(e) => {
                            setHabitacionId(e.target.value);
                        }} /></div>

                        <div><label>huespedId:</label></div>
                        <div><input className="form-control" type="text" value={huespedId} onChange={(e) => {
                            setHuespedId(e.target.value);
                        }} /></div>

                        <div><label>dni:</label></div>
                        <div><input className="form-control" type="text" value={dni} onChange={(e) => {
                            setDni(e.target.value);
                        }} /></div>

                        <div><label>clienteId:</label></div>
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