import React from 'react'
import { Route, Switch } from 'react-router';

import ListaHabitacion from '../pages/Habitaciones/ListaHabitacion';
import FormHabitacion from '../pages/Habitaciones/FormHabitacion';
import DetalleHabitacion from '../pages/Habitaciones/DetalleHabitacion';
import FormCheckin from '../pages/CheckIn/FormCheckIn';
import FormCheckout from '../pages/Checkout/FormCheckout';
import ListaCheckin from '../pages/CheckIn/ListaCheckin';

const RouterConfig = () => {
    return (
        <Switch>

            <Route path="/habitacion" exact>
                <ListaHabitacion />
            </Route>

            <Route path="/habitacion/edit/:id" component={FormHabitacion}>
            </Route>

            <Route path="/habitacion/create">
                <FormHabitacion />
            </Route>

            <Route path="/detallehabitacion/:id">
                <DetalleHabitacion />
            </Route>


            <Route path="/checkin/create" exact>
                <FormCheckin />
            </Route>
            <Route path="/checkin" exact>
                <ListaCheckin />
            </Route>


            <Route path="/checkout/create">
                <FormCheckout />
            </Route>

            <Route path="/">
                <ListaHabitacion />
            </Route>
        </Switch>
    );
}

export default RouterConfig;