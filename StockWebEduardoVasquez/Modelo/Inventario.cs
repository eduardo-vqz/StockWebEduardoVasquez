﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StockWebEduardoVasquez.Modelo
{
    public class Inventario
    {
        private int id;
        private Sucursal_electrodomestico sucursal_electrodomestico;
        private int cantidad_movimiento;
        private string movimiento;

        public Inventario()
        {
            sucursal_electrodomestico = new Sucursal_electrodomestico();
        }

        public Inventario(int id, Sucursal_electrodomestico sucursal_electrodomestico, int cantidad_movimiento, string movimiento)
        {
            this.id = id;
            this.sucursal_electrodomestico = sucursal_electrodomestico;
            this.cantidad_movimiento = cantidad_movimiento;
            this.movimiento = movimiento;
        }

        public int Id { get => id; set => id = value; }
        public int Cantidad_movimiento { get => cantidad_movimiento; set => cantidad_movimiento = value; }
        public string Movimiento { get => movimiento; set => movimiento = value; }
        public Sucursal_electrodomestico Sucursal_electrodomestico { get => sucursal_electrodomestico; set => sucursal_electrodomestico = value; }
    }
}
