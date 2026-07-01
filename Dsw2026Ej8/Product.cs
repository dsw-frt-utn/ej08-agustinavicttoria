using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        //VARIABLE A NIVEL DE CLASE
        private long _code; //variable q representa un atrib para la clase
        private string _description;
        private bool _active; //se crea activo -> active igual a true
        private double _price;
        private float _tax;
        private int _stock;
        private char _presentation;
        private DateTime _date;
        private bool _internal;

        public Product(long code, string description, double price, char presentation)
        {
            _code = code;
            _description = description;
            _price = price;

            _active = true;
            _date = DateTime.Now;
            _internal = false; //se inicializa por defecto en false
            _stock = 0; //se inicializa por defecto en 0
            _tax = 0.21f;

            if (presentation == 'S' || presentation == 'K' || presentation == 'P' || presentation == 'E')

                _presentation = presentation;
            else
                _presentation = 'I';
        }

        //GETS
        public long GetCode()//metodo get para el atributo code
        {
            return _code;
        }

        public string GetDescription()
        {
            return _description;
        }

        public double GetPrice()
        {
            return _price;
        }

        public float GetTax()
        {
            return _tax;
        }

        public int GetStock()
        {
            return _stock;
        }

        public char GetPresentation()
        {
            return _presentation;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public bool GetActive()
        {
            return _active;
        }

        public bool GetInternal()
        {
            return _internal;
        }

        public void SetInternal(bool internalValue)
        {
            _internal = internalValue;
        }

        public void SetTax(float tax)
        {
            _tax = tax;
        }

        public void Deactivate()
        {
            _active = false;
        }

        public double GetFinalPrice()
        {
            return _price * (1 + _tax); //retorno del precio final
        }

        public string GetDetailedInfo()
        {
            string GetStockMessage()
            {
                if (_stock > 0 && _active)
                    return "Disponible";
                else if (!_active)
                    return "No disponible";
                else
                    return "Sin stock";
            }
            return $"[{_code}] {_description} [{_presentation}]: {GetFinalPrice():C2} - {GetStockMessage()}";
        }

        public void IncreaseStock() => _stock++;

        public void DecreaseStock()
        {
            if (_stock - 1 < 0) return;
            _stock--;
        }

        public void IncreaseStock(int amount)
        {
            if (amount < 0) return;
            _stock += amount;
        }

        public double GetPricePerFraction(int fractions)
        {
            if (_presentation != 'K') return 0;
            if (fractions <= 0) return 0;

            return GetFinalPrice() / fractions;
        }

        public string GetPackaging()
        {
            switch (_presentation)
            {
                case 'I':
                    return "Envase Individual";
                case 'S':
                    return "Empaque Secundario";
                case 'K':
                    return "Pack";
                case 'E':
                    return "Eco-friendly";
                case 'P':
                    return "Premium";
                default:
                    return "";
            }
        }

        public void Update( string description, double price = 0, float tax = 0.21F)
        {
            _description = description;

            if (price != 0)
                _price = price;
            if (tax != _tax)
                _tax = tax;
        }
    }
}
