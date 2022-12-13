import axios from 'axios';
import React, { useEffect, useState } from 'react'
import { Card, Col, Form, Row } from 'react-bootstrap';
import { useSelector } from 'react-redux';
import { useHistory } from 'react-router';

const FormHabitacion = (props) => {
    const token = useSelector(state => state.login.token)

    const { id } = props.match ? props.match.params : { id: 0 };
    const history = useHistory();

    const [codigoHabitacion, setCodigoHabitacion] = useState('');
    const [limitePersona, setLimitePersona] = useState('');
    const [tipoHabitacion, setTipoHabitacion] = useState('');
    const [precioHabitacion, setPrecioHabitacion] = useState(0);
    const [numeroHabitacion, setNumeroHabitacion] = useState(0);
    const [caracteristicasHabitacion, setCaracteristicasHabitacion] = useState('');
    const [disponibilidad, setDisponibilidad] = useState('');


    useEffect(() => {

    }, []);


    const enviarDatos = () => {
        const params = {
            "codigoHabitacion": codigoHabitacion,
            "limitePersona": limitePersona,
            "tipoHabitacion": tipoHabitacion,
            "precioHabitacion": precioHabitacion,
            "numeroHabitacion": numeroHabitacion,
            "caracteristicasHabitacion": caracteristicasHabitacion,
            "disponibilidad": disponibilidad
        };
        insertarHabitacion(params);
    }
    const insertarHabitacion = (params) => {

        const url = 'https://localhost:7098/api/Habitacion';
        axios.post(url, params, {
            headers: {
                "Authorization": "Bearer " + token
            }
        }
        ).then(response => {

            console.log('recibido', response.data);
            history.push('/habitacion');
        }).catch(error => {
            console.log(error);


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
                        <Card.Title>Formulario de Habitaciones</Card.Title>

                        <div><label>codigoHabitacion:</label></div>
                        <div><input className="form-control" type="text" value={codigoHabitacion} onChange={(e) => {
                            setCodigoHabitacion(e.target.value);
                        }} /></div>

                        <div><label>limitePersona:</label></div>
                        <div><input className="form-control" type="text" value={limitePersona} onChange={(e) => {
                            setLimitePersona(e.target.value);
                        }} /></div>

                        <div><label>tipoHabitacion:</label></div>
                        <div><input className="form-control" type="text" value={tipoHabitacion} onChange={(e) => {
                            setTipoHabitacion(e.target.value);
                        }} /></div>

                        <div><label>precioHabitacion:</label></div>
                        <div><input className="form-control" type="text" value={precioHabitacion} onChange={(e) => {
                            setPrecioHabitacion(e.target.value);
                        }} /></div>

                        <div><label>numeroHabitacion:</label></div>
                        <div><input className="form-control" type="text" value={numeroHabitacion} onChange={(e) => {
                            setNumeroHabitacion(e.target.value);
                        }} /></div>

                        <div><label>caracteristicasHabitacion:</label></div>
                        <div><input className="form-control" type="text" value={caracteristicasHabitacion} onChange={(e) => {
                            setCaracteristicasHabitacion(e.target.value);
                        }} /></div>

                        <div><label>disponibilidad:</label></div>
                        <div><input className="form-control" type="text" value={disponibilidad} onChange={(e) => {
                            setDisponibilidad(e.target.value);
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

export default FormHabitacion;