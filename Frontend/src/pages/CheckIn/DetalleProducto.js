import axios from "axios";
import React, { useEffect, useState } from "react";
import { Button, Image, ListGroup } from "react-bootstrap";
import { useParams } from "react-router";
import { Link } from "react-router-dom";
import { useSelector } from 'react-redux';


const DetalleProductos = (props) => {
    console.log(useParams())
    const { id } = useParams()
    const token = useSelector(state => state.login.token)

    //  const { id } = props.match ? props.match.params : { id: 0 };

    const [detalle, setDetalle] = useState([]);
    const [detallereceta, setDetalleReceta] = useState([]);
    const [detalleCategoria, setDetalleCategoria] = useState([]);




    useEffect(() => {
        obtenerListaProducto();
        obtenerListaProductoReceta();
        obtenerListaProductoCategoria();
    }, [id]);

    const obtenerListaProducto = () => {
        axios.get(`http://127.0.0.1:8000/api/producto/${id}/`, {
            headers: {
                "Authorization": "Bearer " + token
            }
        }
        ).then(response => {
            console.log('producto', response.data);

            const objProducto = response.data;


            setDetalle(objProducto);

        }).catch(error => {
            // console.log('error', error);
            if (error.response.status === 401) {
            }
        });
    }
    const obtenerListaProductoReceta = () => {
        axios.get(`http://127.0.0.1:8000/api/productoreceta/${id}/`, {
            headers: {
                "Authorization": "Bearer " + token
            }
        }
        ).then(response => {
            console.log('Que hay aca', response.data);

            const objreceta = response.data;


            setDetalleReceta(objreceta);

        }).catch(error => {
            // console.log('error', error);
            if (error.response.status === 401) {
            }
        });
    }
    const obtenerListaProductoCategoria = () => {
        axios.get(`http://127.0.0.1:8000/api/productocategoria/${id}/`, {
            headers: {
                "Authorization": "Bearer " + token
            }
        }
        ).then(response => {
            

            const objcategoria = response.data;

            console.log('producto', objcategoria);
            setDetalleCategoria(objcategoria);

        }).catch(error => {
            // console.log('error', error);
            if (error.response.status === 401) {
            }
        });
    }
    return (
        <div>
            <h1>Pedido</h1>
            
            <ListGroup >
                    <ListGroup.Item>Nombre : {detalle.nombre}</ListGroup.Item>
                    <ListGroup.Item>{detalle.precio}</ListGroup.Item>
                    <h1>Receta</h1>
                    <ListGroup.Item>{detallereceta.nombre}</ListGroup.Item>
                    <ListGroup.Item>{detallereceta.descripcion}</ListGroup.Item>

                    <h1>Categoria</h1>
                    <ListGroup.Item>{detalleCategoria.nombre} </ListGroup.Item>
                    <ListGroup.Item>{detalleCategoria.descripcion}</ListGroup.Item>
            </ListGroup>
        </div>
    );
}

export default DetalleProductos;