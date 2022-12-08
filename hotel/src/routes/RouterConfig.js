import React from 'react'
import { Route, Routes } from 'react-router-dom'

import Checkout from '../pages/checkout/Checkout'

import { Reserva } from '../pages/reservas/Reserva'


export const RouterConfig = () => {
  return (
    <Routes>
        <Route path='/' element={<Reserva></Reserva>}></Route>
        <Route path='/checkout' element={<Checkout></Checkout>}></Route>
    </Routes>
  )
}
