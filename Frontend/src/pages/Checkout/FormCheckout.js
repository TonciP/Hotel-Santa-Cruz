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




    useEffect(() => {

    }, []);


    const enviarDatos = () => {
        const params = {
            "clienteId": clienteId,
            "creditCardId": creditCardId,
            "checkInId": checkInId,
            "factura": {
                "facturaId": facturaId,
                "detalleFactura": detalleFactura,
                "numeroFactura": numeroFactura,
                "total": totalfactura,
                "fecha": fecha
            },
            "pago": {
                "pagoId": pagoId,
                "total": total
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
                        <Card.Title>Hacer de CheckIn</Card.Title>

                        <div><label>clienteId:</label></div>
                        <div><input className="form-control" type="text" value={clienteId} onChange={(e) => {
                            setClienteId(e.target.value);
                        }} /></div>

                        <div><label>creditCardId:</label></div>
                        <div><input className="form-control" type="text" value={creditCardId} onChange={(e) => {
                            setCreditCardId(e.target.value);
                        }} /></div>

                        <div><label>checkInId:</label></div>
                        <div><input className="form-control" type="text" value={checkInId} onChange={(e) => {
                            setCheckInId(e.target.value);
                        }} /></div>

                        <div><label>facturaId:</label></div>
                        <div><input className="form-control" type="text" value={facturaId} onChange={(e) => {
                            setFacturaId(e.target.value);
                        }} /></div>

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

                        <div><label>pagoId:</label></div>
                        <div><input className="form-control" type="text" value={pagoId} onChange={(e) => {
                            setPagoId(e.target.value);
                        }} /></div>

                        <div><label>total:</label></div>
                        <div><input className="form-control" type="text" value={total} onChange={(e) => {
                            setTotal(e.target.value);
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