using System;
using System.Runtime.InteropServices;


    [ComVisible(true)]
[ComImport, Guid("1A631CB5-AC23-4513-BD65-E74801155479")]
    public class Car
    {
    }

    //{960EFB55-5A90-45F8-8C6C-12849DCF2AC1}
    //DEFINE_GUID(IID_ICreateCar,
    //0x960efb55, 0x5a90, 0x45f8, 0x8c, 0x6c, 0x12, 0x84, 0x9d, 0xcf, 0x2a, 0xc1);
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("BE2C4E3C-AAB8-4090-AD8F-CD1BF8A5C8B5")]
    public interface ICreateCar
    {
        void SetPetName(string petName);
        void SetMaxSpeed(int maxSp);
    }

    // {4601678B-6D77-446F-8782-CC054440F81F}
    //DEFINE_GUID(IID_IStats,
    //0x4601678b, 0x6d77, 0x446f, 0x87, 0x82, 0xcc, 0x5, 0x44, 0x40, 0xf8, 0x1f);
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0DB382D8-B41D-42A7-AA8B-B39FC79E4358")]
    public interface IStats
    {
        void DisplayStats();
        void GetPetName(ref string petName);
    }
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("8DB90CF3-DFAF-410E-8EB1-65654A5A4207")]
    public interface IEngine
    {
        void SpeedUp();
        void GetMaxSpeed(ref int curSpeed);
        void GetCurSpeed(ref int maxSpeed);
    }

    class Program
    {
        static void Main()
        {
            Car myCar = new();
            ICreateCar iCrCar = (ICreateCar)myCar;
            Console.WriteLine("Напишите имя: ");
            iCrCar.SetPetName(Console.ReadLine());

        }
    }