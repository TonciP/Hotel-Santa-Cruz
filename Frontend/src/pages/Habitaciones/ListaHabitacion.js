import axios from 'axios';
import React, { useEffect, useState } from 'react'
import { Button, Card, Image } from 'react-bootstrap';
import { useSelector } from 'react-redux';
import { Link } from 'react-router-dom';
import { useHistory } from 'react-router';

const ListaHabitacion = () => {
    const token = localStorage.getItem('token')
    //const permisos = useSelector(state => state.login.permisos);
    const history = useHistory();

    const [lista, setLista] = useState([]);
    const [cargando, setCargando] = useState(false);

    useEffect(() => {

        obtenerListaHabitacion();
    }, []);

    const obtenerListaHabitacion = () => {
        setCargando(true);
        axios.get("https://localhost:7272/api/Habitacion/search", {
            headers: {
                "Authorization": "Bearer " + token
            }
        }).then(response => {
            console.log('response', response.data);
            console.log(localStorage.getItem('token'));

            setLista(response.data);
            setCargando(false);
        }).catch(error => {
            // console.log('error', error);
            if (error.response.status === 401) {
                history.push('/login');
            }
        });
    }
    const enviarDatos = (codigo) => {
        const params = {
            "habitacion": codigo,
        };
        eliminarHabitacion(params);
    }

    const eliminarHabitacion = (params) => {
        const confirmation = window.confirm('¿Está seguro que desea eliminar?');
        if (!confirmation) {
            return;
        }
        const url = 'https://localhost:7098/api/Habitacion';
        axios.delete(url, params, {
            headers: {
                "Authorization": "Bearer " + token
            }
        }
        ).then((response) => {
            obtenerListaHabitacion();
        }).catch(error => {
            console.log(error);
        });
    }
    return <div>
        {cargando === true && <h1>Cargando...</h1>}
        {cargando === false &&
            <Card className="mt-3">
                <Card.Body>
                    <Card.Title>Habitaciones</Card.Title>

                    <table className="table">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Codigo</th>
                                <th>Limite Personas</th>
                                <th>Caracteristica</th>
                                <th>Disponibilidad</th>
                            </tr>
                        </thead>
                        <tbody>
                            {lista.map(item =>
                                <tr key={"item-" + item.id}>
                                    <td>{item.habitacionId}</td>
                                    <td>{item.codigoHabitacion}</td>
                                    <td>{item.limitePersona}</td>
                                    <td>{item.caracteristicasHabitacion}</td>
                                    <td>{item.disponibilidad}</td>

                                    <td>
                                        <Link className="btn btn-primary" to={"/habitacion/edit/" + item.codigoHabitacion}>Editar</Link>
                                    </td>

                                    <td>
                                        <button className="btn btn-danger" onClick={() => { enviarDatos(item.habitacionId) }}>Eliminar</button>
                                    </td>

                                    <td>
                                        <Link className="btn btn-success" to={"/detallehabitacion/" + item.codigoHabitacion}>Ver</Link>
                                    </td>
                                </tr>
                            )}

                        </tbody>
                    </table>
                </Card.Body>
            </Card>
        }
    </div >;
}

export default ListaHabitacion;