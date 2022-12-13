import React from 'react'
import { Route, Routes } from 'react-router-dom'
import Checkin from '../pages/CheckIn/Checkin'
import ListaHuespedes from '../pages/CheckIn/ListaClientes'

import Checkout from '../pages/checkout/Checkout'

import { Reserva } from '../pages/reservas/Reserva'


export const RouterConfig = () => {
  return (
    <Routes>
        <Route path='/' element={<Reserva></Reserva>}></Route>
        <Route path='/checkout' element={<Checkout></Checkout>}></Route>
        <Route path='/checkin' element={<Checkin></Checkin>}></Route>
        <Route path='/huespedes' element={<ListaHuespedes></ListaHuespedes>}></Route>

    </Routes>
  )
}
