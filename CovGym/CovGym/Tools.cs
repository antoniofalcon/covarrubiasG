using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace CovGym
{
    class Tools
    {
        public string calle="";
        public string numero = "";
        public string col = "";
        public string cp = "";
        public string fecha;

      
        public string DMYToYMD(string date)
        {
            try
            {
                return Regex.Replace(date,
                      @"\b(?<day>\d{1,2})/(?<month>\d{1,2})/(?<year>\d{2,4})\b",
                      "${year}-${month}-${day}", RegexOptions.None,
                      TimeSpan.FromMilliseconds(150));
            }
            catch (RegexMatchTimeoutException)
            {
                return date;
            }
        }
        public void QuitarHora(string date)
        {
            fecha = "";
            for (int i = 0; i < date.Length; i++)
            {
                if (i<10)
                {
                    fecha = fecha + date[i];
                }
                
            }
        }

        public void ObtenerCalle(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' && text[i+1] == '#')
                {
                    for (int j = i + 2; j < text.Length; j++)
                    {
                        if (text[j] == ' '&& text[j+1] == 'C' && text[j+2]=='O' && text[j+3] == 'L' && text[j+4] == '.')
                        {
                            for (int k = j + 6; k < text.Length; k++)
                            {
                                if (text[k] == ' '&& text[k+1] == 'C' && text[k+2]=='.' && text[k+3] == 'P' && text[k+4] == '.')
                                {
                                    for (int l = k + 6; l < text.Length; l++)
                                    {
                                        if (l == text.Length - 1)
                                        {
                                            cp = cp + text[l];
                                            return;
                                        }
                                        cp = cp + text[l];
                                    }
                                }
                                col = col + text[k];
                            }
                        }
                        numero = numero + text[j];
                    }
                }
                calle = calle + text[i];                
            }

            /*try
            {
                return Regex.Replace(text,
                      @"\b(?<calle>[a-zA-ZñÑ0-9\s])\#(?<num>[a-zA-Z0-9-\s])\COL.-s(?<col>[a-zA-ZñÑ0-9\s])\CP.-s(?<cp>\d{5})\b",
                      "${calle}", RegexOptions.None,
                      TimeSpan.FromMilliseconds(150));
            }
            catch (RegexMatchTimeoutException)
            {
                return "agua";
            }*/
        }

        public Boolean ValidCP(string text)
        {
            string expresion;
            expresion = @"^\d{5}$";
            if (Regex.IsMatch(text, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean ValidCode(string text)
        {
            string expresion;
            expresion = @"^\d{4}$";
            if (Regex.IsMatch(text, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Boolean ValidDecimal(string text)
        {
            string expresion;
            expresion = @"^\d{1,10}(\.\d{2})?$";
            if (Regex.IsMatch(text, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidTalla(string text)
        {
            string expresion;
            expresion = @"^\d{1}(\.\d{2})?$";
            if (Regex.IsMatch(text, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean ValidMedida(string text)
        {
            string expresion;
            expresion = @"^\d{2,3}(\.\d{0,2})?$";
            if (Regex.IsMatch(text, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public Boolean ValidAlfa(string text)
        {
            string expresion;
            expresion = @"^[a-zA-ZñÑ0-9\s]{3,60}$";
            if (Regex.IsMatch(text, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean ValidCuenta(string text)
        {
            string expresion;
            expresion = @"^[a-zA-ZñÑ0-9]{3,60}$";
            if (Regex.IsMatch(text, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean ValidNumDir(string text)
        {
            string expresion;
            expresion = @"^[a-zA-Z0-9-\s]{3,60}$";
            if (Regex.IsMatch(text, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidText(string text)
        {
            string expresion;
            expresion = @"^[a-zA-ZñÑ\s]{3,60}$";
            if (Regex.IsMatch(text, expresion))
            {
                if (Regex.Replace(text, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidPhone(string number)
        {
            string expresion;
            expresion = @"\b\d{2}-\d{2}-\d{2}-\d{2}-\d{2}\b";
            if (Regex.IsMatch(number, expresion))
            {
                if (Regex.Replace(number, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Boolean ValidEmail(string email)
        {
            string expresion;
            expresion = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
