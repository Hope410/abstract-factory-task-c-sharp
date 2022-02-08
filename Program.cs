using System;

namespace iis_task
{
  public interface ICityCar
  {
    string DriveInCity();
  }

  public interface IMiniVan
  {
    string TransportPassangers();
  }

  public interface IOffRoadCar
  {
    string DriveInMountains();
  }

  public interface ICarFactory
  {
    ICityCar BuildCityCar();
    IMiniVan BuildMiniVan();
    IOffRoadCar BuildOffRoadCar();
  }

  public class HyundaiCityCar : ICityCar
  {
    string ICityCar.DriveInCity()
    {
      return "Легковая машина Hyundai едет по городу";
    }
  }

  public class HyundaiMiniVan : IMiniVan
  {
    string IMiniVan.TransportPassangers()
    {
      return "Минивэн Hyundai перевозит людей";
    }
  }

  public class HyundaiOffRoadCar : IOffRoadCar
  {
    string IOffRoadCar.DriveInMountains()
    {
      return "Внедорожник Hyundai едет по горам";
    }
  }

  public class HyundaiFactory : ICarFactory
  {
    ICityCar ICarFactory.BuildCityCar()
    {
      return new HyundaiCityCar();
    }

    IMiniVan ICarFactory.BuildMiniVan()
    {
      return new HyundaiMiniVan();
    }

    IOffRoadCar ICarFactory.BuildOffRoadCar()
    {
      return new HyundaiOffRoadCar();
    }
  }

  public class FordCityCar : ICityCar
  {
    string ICityCar.DriveInCity()
    {
      return "Легковая машина Ford едет по городу";
    }
  }

  public class FordMiniVan : IMiniVan
  {
    string IMiniVan.TransportPassangers()
    {
      return "Минивэн Ford перевозит людей";
    }
  }

  public class FordOffRoadCar : IOffRoadCar
  {
    string IOffRoadCar.DriveInMountains()
    {
      return "Внедорожник Ford едет по горам";
    }
  }

  public class FordFactory : ICarFactory
  {
    ICityCar ICarFactory.BuildCityCar()
    {
      return new FordCityCar();
    }

    IMiniVan ICarFactory.BuildMiniVan()
    {
      return new FordMiniVan();
    }

    IOffRoadCar ICarFactory.BuildOffRoadCar()
    {
      return new FordOffRoadCar();
    }
  }

  public class VolkswagenCityCar : ICityCar
  {
    string ICityCar.DriveInCity()
    {
      return "Легковая машина Volkswagen едет по городу";
    }
  }

  public class VolkswagenMiniVan : IMiniVan
  {
    string IMiniVan.TransportPassangers()
    {
      return "Минивэн Volkswagen перевозит людей";
    }
  }

  public class VolkswagenOffRoadCar : IOffRoadCar
  {
    string IOffRoadCar.DriveInMountains()
    {
      return "Внедорожник Volkswagen едет по горам";
    }
  }

  public class VolkswagenFactory : ICarFactory
  {
    ICityCar ICarFactory.BuildCityCar()
    {
      return new VolkswagenCityCar();
    }

    IMiniVan ICarFactory.BuildMiniVan()
    {
      return new VolkswagenMiniVan();
    }

    IOffRoadCar ICarFactory.BuildOffRoadCar()
    {
      return new VolkswagenOffRoadCar();
    }
  }

  class FactoryTestingEnvironment
  {
    public void Main()
    {
      Console.WriteLine("Проверка машин завода Hyundai:");
      Test(new HyundaiFactory());
      Console.WriteLine();

      Console.WriteLine("Проверка машин завода Ford:");
      Test(new FordFactory());
      Console.WriteLine();

      Console.WriteLine("Проверка машин завода Volkswagen:");
      Test(new VolkswagenFactory());
      Console.WriteLine();
    }

    public void Test(ICarFactory factory)
    {
      var cityCar = factory.BuildCityCar();
      var miniVan = factory.BuildMiniVan();
      var offRoadCar = factory.BuildOffRoadCar();

      Console.WriteLine(cityCar.DriveInCity());
      Console.WriteLine(miniVan.TransportPassangers());
      Console.WriteLine(offRoadCar.DriveInMountains());
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      new FactoryTestingEnvironment().Main();
    }
  }
}