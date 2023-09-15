namespace Library.Tests;

using Ucu.Poo.TestDateFormat;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFechaFormatoCorrecto()
    {
        /* arrange */
        string miFecha ="10/12/2024";
        string resultadoEsperado = "2024-12-10";

        /* act */
        string resultadoObtenido = DateFormatter.ChangeFormat(miFecha);

        /* assert */
        Assert.That(resultadoObtenido, Is.EqualTo(resultadoEsperado));
      
    }

    [Test]
    public void TestFechaEnBlanco()
    {
        /* arrange */
        string miFecha =" ";
        Assert.Catch<Exception>(() => DateFormatter.ChangeFormat(miFecha));
    
    }

    [Test]
    public void TestFechaFormatoIncorrecto()
    {
        /* arrange */
        string miFecha= "08/99/1999";
        Assert.Catch<Exception>(() => DateFormatter.ChangeFormat(miFecha));
    } 
}