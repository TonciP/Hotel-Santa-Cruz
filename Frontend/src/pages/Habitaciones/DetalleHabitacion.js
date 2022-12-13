import axios from "axios";
import React, { useEffect, useState } from "react";
import { Button, Image, ListGroup } from "react-bootstrap";
import { useParams } from "react-router";
import { Link } from "react-router-dom";
import { useSelector } from 'react-redux';


const DetalleHabitacion = (props) => {
    console.log(useParams())
    const { id } = useParams()
    const token = useSelector(state => state.login.token)

    //  const { id } = props.match ? props.match.params : { id: 0 };

    const [detalle, setDetalle] = useState([]);

    useEffect(() => {
        obtenerListaHabitacion();
    }, [id]);

    const obtenerListaHabitacion = () => {
        axios.get(`https://localhost:7098/api/Habitacion/search?codigo=${id}`, {
            headers: {
                "Authorization": "Bearer " + token
            }
        }
        ).then(response => {
            console.log('Que hay aca', response.data);

            const objHabitacion = response.data;


            setDetalle(objHabitacion);

        }).catch(error => {
            // console.log('error', error);
            if (error.response.status === 401) {
            }
        });
    }
    return (
        <div>
            <h1>Habitacion Detalle</h1>
            {detalle.map((detalle) =>
            <ListGroup key={detalle.id}>
                    <ListGroup.Item>ID Habitacion : {detalle.habitacionId}</ListGroup.Item>
                    <ListGroup.Item>Codigo Habitacion : {detalle.codigoHabitacion}</ListGroup.Item>
                    <ListGroup.Item>Limite Personas : {detalle.limitePersona}</ListGroup.Item>
                    <ListGroup.Item>Tipo De Habitacion : {detalle.tipoHabitacion}</ListGroup.Item>
                    <ListGroup.Item>Precio Habitacion : {detalle.precioHabitacion}</ListGroup.Item>
                    <ListGroup.Item>Numero Habitacion : {detalle.numeroHabitacion}</ListGroup.Item>
                    <ListGroup.Item>Caracteristica : {detalle.caracteristicasHabitacion} </ListGroup.Item>
                    <ListGroup.Item>Disponibilidad : {detalle.disponibilidad}</ListGroup.Item>
            </ListGroup>
            )}
        </div>
    );
}

export default DetalleHabitacion;