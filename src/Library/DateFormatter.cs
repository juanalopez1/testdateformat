namespace Ucu.Poo.TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if (date.Length == 0 || date == " ")
        {
            throw new Exception ("la fecha ingresada está en blanco");    
        }
        else if (date.Contains("-") || !date.Substring(0,4).Contains("/") || int.Parse(date.Substring(3,2))>12) 
        /* estas condiciones generan que si se ingresa una fecha de tipo yyyy-mm-dd, que en donde 
        va el dia este un año, o se ingrese un mes inexistente, no se pueda ejecutar ChangeFormat.*/
        {
            throw new Exception ("se esperaba una fecha de formato dd/mm/yyyy");
        }
        else
        // año                              mes                         dia
        {
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }
        
    }
}
