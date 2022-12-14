import React, { useEffect, useState } from 'react'
import { Button, Container, Nav, Navbar, NavDropdown } from 'react-bootstrap';
import { useDispatch, useSelector } from 'react-redux';
import { Link } from 'react-router-dom';
import { sesionCerrada } from '../redux/loginSlice';
import { useHistory } from 'react-router';
const Header = () => {
    const dispatch = useDispatch();
    const history = useHistory();

    //const token = useSelector(state => state.login.token);


    useEffect(() => {

        let obj = [
            {
                "nombre": "pizza",
                "precio": 100
            },
            {
                "nombre": "hambuguersa",
                "precio": 100
            },
            {
                "nombre": "taco",
                "precio": 100
            }

        ]

        /*if (!token) {
            history.push('/login');
        }*/
    }, [/*token*/])

    return (
        <Navbar bg="dark" variant="dark" expand="lg">
            <Container>
                <Navbar.Brand href="#home">Hotel Santa Cruz</Navbar.Brand>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav">


                    <Nav className="me-auto">

                        <NavDropdown title="Habitaciones" id="basic-nav-dropdown">
                            <Link className="dropdown-item" to="/habitacion">Ver Habitaciones</Link>
                            <Link className="dropdown-item" to="/habitacion/create">Crear Habitaciones</Link>
                        </NavDropdown>

                        <NavDropdown title="CheckIn" id="basic-nav-dropdown">
                            <Link className="dropdown-item" to="/checkin">Ver CheckIn</Link>
                            <Link className="dropdown-item" to="/checkin/create">Crear CheckIn</Link>
                        </NavDropdown>

                        <NavDropdown title="CheckOut" id="basic-nav-dropdown">
                            <Link className="dropdown-item" to="/checkout/create">Crear CheckOut</Link>
                        </NavDropdown>

                    </Nav>

                </Navbar.Collapse>
            </Container>
        </Navbar>
    );
}

export default Header;