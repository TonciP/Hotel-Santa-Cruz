import axios from 'axios';
import React, { useEffect, useState } from 'react'
import { Card, Col, Form, Row } from 'react-bootstrap';
import { useSelector } from 'react-redux';
import { useHistory } from 'react-router';

const FormCheckout = (props) => {
    const token = useSelector(state => state.login.token)

    const { id } = props.match ? props.match.params : { id: 0 };
    const history = useHistory();

    const [clienteId, setClienteId] = useState('');
    const [creditCardId, setCreditCardId] = useState('');
    const [checkInId, setCheckInId] = useState('');
    const [facturaId, setFacturaId] = useState('');
    const [detalleFactura, setDetalleFactura] = useState('');
    const [numeroFactura, setNumeroFactura] = useState(0);
    const [totalfactura, setTotalfactura] = useState(0);
    const [fecha, setFecha] = useState('');
    const [pagoId, setPagoId] = useState('');
    const [total, setTotal] = useState(0);
    const [checkin, setCheckin] = useState([]);





    useEffect(() => {
        fetchDatosCheckin();
    }, []);

    const fetchDatosCheckin = () => {

        const url = 'https://localhost:7272/api/Checkin/search';
        axios.get(url
        )
            .then((response) => {
                console.log('fetchDatosCheckin', response.data);
                const objCheckin = response.data;
                console.log('objCheckin', objCheckin);
                setCheckin(objCheckin);

            }).catch(error => {
                // console.log('error', error);
                if (error.response.status === 401) {
                    history.push('/habitacion');
                }
            });
    }
    const enviarDatos = () => {
        const params = {
            "clienteId": "ccaeef0e-1184-49bc-8050-b7e43884f66c",
            "creditCardId": creditCardId,
            "checkInId": checkInId,
            "factura": {
                "facturaId": "ccaeef0e-1184-49bc-8050-b7e43884f66c",
                "detalleFactura": detalleFactura,
                "numeroFactura": numeroFactura,
                "total": totalfactura,
                "fecha": fecha
            },
            "pago": {
                "pagoId": "ccaeef0e-1184-49bc-8050-b7e43884f66c",
                "total": totalfactura
            }
        };
        insertarCheckout(params);
    }
    const insertarCheckout = (params) => {

        const url = 'https://localhost:7098/api/Checkout';
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
                        <Card.Title>Hacer de CheckOut</Card.Title>

                        <div><label>Credit Card:</label></div>
                        <div><input className="form-control" type="text" value={creditCardId} onChange={(e) => {
                            setCreditCardId(e.target.value);
                        }} /></div>

                        <div><label>CheckIn:</label></div>
                        <select name="checkin" className='form-control' onChange={(e) => {
                            setCheckInId(e.target.value);
                        }}>
                            {checkin.map(elemento => (
                                <option key={elemento.checkinId} value={elemento.checkinId}>{elemento.checkinId}</option>
                            )
                            )}
                        </select>

                        <Card.Title>Facturacion</Card.Title>

                        <div><label>detalleFactura:</label></div>
                        <div><input className="form-control" type="text" value={detalleFactura} onChange={(e) => {
                            setDetalleFactura(e.target.value);
                        }} /></div>

                        <div><label>numeroFactura:</label></div>
                        <div><input className="form-control" type="text" value={numeroFactura} onChange={(e) => {
                            setNumeroFactura(e.target.value);
                        }} /></div>

                        <div><label>totalfactura:</label></div>
                        <div><input className="form-control" type="text" value={totalfactura} onChange={(e) => {
                            setTotalfactura(e.target.value);
                        }} /></div>

                        <div><label>fecha:</label></div>
                        <div><input className="form-control" type="text" value={fecha} onChange={(e) => {
                            setFecha(e.target.value);
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

export default FormCheckout;