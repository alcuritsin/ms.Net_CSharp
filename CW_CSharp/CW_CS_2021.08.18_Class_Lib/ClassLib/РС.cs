using System;

namespace ClassLib
{
    public class PC
    {
        //  Объявляем делегат
        public delegate void PCStateHandler(string message);
        //public event PCStateHandler _eve;
        //  Создаём переменную делегата
        public PCStateHandler _del;

        public void RegistrHandler(PCStateHandler del)
        {
            if (_del == null)
            {
                _del = del;
            }
            else
            {
                _del += del;
            }
        }
        //public Action action; // !!!
        public string Brand { get; set; }
        public string SerialNumber { get; set; }
        public string RAM { get; set; }
        public string VGA { get; set; }

        public bool IsOn { get; set; }

        public PC() { }
        public PC(string brand, string serialNumber, string RAM, string VGA)
        {
            Brand = brand;
            SerialNumber = serialNumber;
            this.RAM = RAM;
            this.VGA = VGA;
            IsOn = false;  //  При созданиии выключен.
        }

        public bool PowerOn()
        {
            //  Включение ПК
            if (_del != null)
            {
                _del("operation: PowerOn");
            }
            //action?.Invoke("operation: PowerOn");
            //_eve?.Invoke("operation: PowerOn");
            //  Включение
            if (!IsOn)
            {
                IsOn = true;
                //if (_del!=null)
                //{
                //    _del("PC is turned on.");   //  Компьютер включен
                //}
                _del?.Invoke("PC is turned on.");
                return true;
            }
            else
            {
                if (_del != null)
                {
                    _del("PC is already turned on.");  //  Компьютер уже включен
                }
                return false;
            }
        }
        public bool PowerOff()
        {
            //  Выключение ПК
            if (_del != null)
            {
                _del("operation: PowerOff");
            }
            //  Включение
            if (IsOn)
            {
                IsOn = false;
                if (_del != null)
                {
                    _del("PC is turned off.");   //  Компьютер выключен
                }
                return true;
            }
            else
            {
                if (_del != null)
                {
                    _del("PC is already turned off.");  //  Компьютер уже выключен
                }
                return false;
            }
        }
        public bool Reboot()
        {
            //  Перезагрузка ПК
            if (_del != null)
            {
                _del("operation: Reboot");
            }
            if (IsOn)
            {
                PowerOff();
                PowerOn();
                return true;
            }
            else
            {
                if (_del != null)
                {
                    _del("PC is turned off. You cannot restart a PC that is turned off");  //  Компьютер выключен. Нельзя перезагрузить ПК если он выключен.
                }
                return false;
            }
        }
        public void info()
        {
            if (_del != null)
            {
                _del($"brand: {Brand}\t" +
                    $"serialNumber: {SerialNumber}\t" +
                    $"RAM: {RAM}\t" +
                    $"VGA: {VGA}\t" +
                    "power: " + (IsOn ? "on" : "off"));
            }
        }
    }
}
