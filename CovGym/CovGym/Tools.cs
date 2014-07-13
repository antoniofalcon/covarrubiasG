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
        public string ConvertFloatToString(float val)
        {
            string temp = "";
            string temp2 = "";
            int decim = 0;
            string valor = Convert.ToString(val);
            for (int i = 0; i < valor.Length; i++)
            {

                if (valor[i] == '.')
                {
                    temp2 += valor.Substring(i + 1);
                    decim = int.Parse(temp2);
                    break;
                }
                temp += valor[i];
            }
            int value = int.Parse(temp);

            string result = "";

            int dmillar = 0;
            int umillar = 0;
            int decena = 0;
            int centena = 0;
            int millar = 0;
            int unidad = 0;
            int uCent = 0;
            int dCent = 0;

            //Get values in unit..
            dmillar = value / 100000;
            value = value % 100000;
            if (value >= 30000)
            {
                umillar = value / 10000;
                value = value % 10000;
            }
            millar = value / 1000;
            value = value % 1000;
            centena = value / 100;
            value = value % 100;
            if (value >= 30)
            {
                decena = value / 10;
                value = value % 10;
                unidad = value;
            }
            else
            {
                unidad = value % 100;
            }

            //centavos
            if (decim >= 30)
            {
                dCent = decim / 10;
                decim = decim % 10;
                uCent = decim;
            }
            else
            {
                uCent = decim % 100;
            }

            //pesos
            switch (dmillar)
            {
                case 1:
                    if (dmillar != 0 || millar != 0)
                    {

                        result += "ciento ";
                    }
                    else
                    {
                        result += "cien ";
                    }
                    break;
                case 2:
                    result += "docientos ";
                    break;
                case 3:
                    result += "trescientos ";
                    break;
                case 4:
                    result += "cuatrocientos ";
                    break;
                case 5:
                    result += "quinientos ";
                    break;
                case 6:
                    result += "seiscientos ";
                    break;
                case 7:
                    result += "setecientos ";
                    break;
                case 8:
                    result += "ochocientos ";
                    break;
                case 9:
                    result += "novecientos ";
                    break;
            }

            switch (umillar)
            {
                case 3: result += "treinta ";
                    break;
                case 4: result += "cuarenta ";
                    break;
                case 5: result += "cincuenta ";
                    break;
                case 6: result += "sesenta ";
                    break;
                case 7: result += "setenta ";
                    break;
                case 8: result += "ochenta ";
                    break;
                case 9: result += "noventa ";
                    break;
            }

            if (umillar != 0 && millar != 0)
            {
                result += "y ";
            }

            switch (millar)
            {

                case 1: if (umillar != 0)
                    {
                        result += "un ";
                    }
                    else
                    {
                        result += "";
                    }
                    break;
                case 2: result += "dos ";
                    break;
                case 3: result += "tres ";
                    break;
                case 4: result += "cuatro ";
                    break;
                case 5: result += "cinco ";
                    break;
                case 6: result += "seis ";
                    break;
                case 7: result += "siete ";
                    break;
                case 8: result += "ocho ";
                    break;
                case 9: result += "nueve ";
                    break;
                case 10: result += "diez ";
                    break;
                case 11: result += "once ";
                    break;
                case 12: result += "doce ";
                    break;
                case 13: result += "trece ";
                    break;
                case 14: result += "catorce ";
                    break;
                case 15: result += "quince ";
                    break;
                case 16: result += "dieciséis ";
                    break;
                case 17: result += "diecisiete ";
                    break;
                case 18: result += "dieciocho ";
                    break;
                case 19: result += "diecinueve ";
                    break;
                case 20: result += "veinte ";
                    break;
                case 21: result += "veintiún ";
                    break;
                case 22: result += "veintidós ";
                    break;
                case 23: result += "veintitrés ";
                    break;
                case 24: result += "veinticuatro ";
                    break;
                case 25: result += "veinticinco ";
                    break;
                case 26: result += "veintiséis ";
                    break;
                case 27: result += "veintisiete ";
                    break;
                case 28: result += "veintiocho ";
                    break;
                case 29: result += "veintinueve ";
                    break;
            }

            if (umillar != 0 || millar != 0)
            {
                result += "mil ";
            }

            switch (centena)
            {
                case 1:
                    if (decena != 0 || unidad != 0)
                    {

                        result += "ciento ";
                    }
                    else
                    {
                        result += "cien ";
                    }
                    break;
                case 2:
                    result += "docientos ";
                    break;
                case 3:
                    result += "trescientos ";
                    break;
                case 4:
                    result += "cuatrocientos ";
                    break;
                case 5:
                    result += "quinientos ";
                    break;
                case 6:
                    result += "seiscientos ";
                    break;
                case 7:
                    result += "setecientos ";
                    break;
                case 8:
                    result += "ochocientos ";
                    break;
                case 9:
                    result += "novecientos ";
                    break;
            }

            switch (decena)
            {
                case 3: result += "treinta ";
                    break;
                case 4: result += "cuarenta ";
                    break;
                case 5: result += "cincuenta ";
                    break;
                case 6: result += "sesenta ";
                    break;
                case 7: result += "setenta ";
                    break;
                case 8: result += "ochenta ";
                    break;
                case 9: result += "noventa ";
                    break;
            }

            if (decena != 0 && unidad != 0)
            {
                result += "y ";
            }

            switch (unidad)
            {

                case 1: result += "un ";
                    break;
                case 2: result += "dos ";
                    break;
                case 3: result += "tres ";
                    break;
                case 4: result += "cuatro ";
                    break;
                case 5: result += "cinco ";
                    break;
                case 6: result += "seis ";
                    break;
                case 7: result += "siete ";
                    break;
                case 8: result += "ocho ";
                    break;
                case 9: result += "nueve ";
                    break;
                case 10: result += "diez ";
                    break;
                case 11: result += "once ";
                    break;
                case 12: result += "doce ";
                    break;
                case 13: result += "trece ";
                    break;
                case 14: result += "catorce ";
                    break;
                case 15: result += "quince ";
                    break;
                case 16: result += "dieciséis ";
                    break;
                case 17: result += "diecisiete ";
                    break;
                case 18: result += "dieciocho ";
                    break;
                case 19: result += "diecinueve ";
                    break;
                case 20: result += "veinte ";
                    break;
                case 21: result += "veintiún ";
                    break;
                case 22: result += "veintidós ";
                    break;
                case 23: result += "veintitrés ";
                    break;
                case 24: result += "veinticuatro ";
                    break;
                case 25: result += "veinticinco ";
                    break;
                case 26: result += "veintiseis ";
                    break;
                case 27: result += "veintisiete ";
                    break;
                case 28: result += "veintiocho ";
                    break;
                case 29: result += "veintinueve ";
                    break;
            }

            if (unidad == 1 && decena != 0 && centena != 0 && millar != 0 && umillar != 0 && dmillar != 0)
            {
                result += "peso ";
            }
            else
            {
                result += "pesos ";
            }

            //centavos
            if (uCent != 0 || dCent != 0)
            {
                if (uCent != 0 || dCent != 0 || unidad != 0 || decena != 0 || centena != 0 || millar != 0 || umillar != 0 || dmillar != 0)
                {
                    result += "con ";
                }

                switch (dCent)
                {
                    case 3: result += "treinta ";
                        break;
                    case 4: result += "cuarenta ";
                        break;
                    case 5: result += "cincuenta ";
                        break;
                    case 6: result += "sesenta ";
                        break;
                    case 7: result += "setenta ";
                        break;
                    case 8: result += "ochenta ";
                        break;
                    case 9: result += "noventa ";
                        break;
                }

                if (dCent != 0 && uCent != 0)
                {
                    result += "y ";
                }

                switch (uCent)
                {

                    case 1: result += "un ";
                        break;
                    case 2: result += "dos ";
                        break;
                    case 3: result += "tres ";
                        break;
                    case 4: result += "cuatro ";
                        break;
                    case 5: result += "cinco ";
                        break;
                    case 6: result += "seis ";
                        break;
                    case 7: result += "siete ";
                        break;
                    case 8: result += "ocho ";
                        break;
                    case 9: result += "nueve ";
                        break;
                    case 10: result += "diez ";
                        break;
                    case 11: result += "once ";
                        break;
                    case 12: result += "doce ";
                        break;
                    case 13: result += "trece ";
                        break;
                    case 14: result += "catorce ";
                        break;
                    case 15: result += "quince ";
                        break;
                    case 16: result += "dieciséis ";
                        break;
                    case 17: result += "diecisiete ";
                        break;
                    case 18: result += "dieciocho ";
                        break;
                    case 19: result += "diecinueve ";
                        break;
                    case 20: result += "veinte ";
                        break;
                    case 21: result += "veintiún ";
                        break;
                    case 22: result += "veintidós ";
                        break;
                    case 23: result += "veintitrés ";
                        break;
                    case 24: result += "veinticuatro ";
                        break;
                    case 25: result += "veinticinco ";
                        break;
                    case 26: result += "veintiseis ";
                        break;
                    case 27: result += "veintisiete ";
                        break;
                    case 28: result += "veintiocho ";
                        break;
                    case 29: result += "veintinueve ";
                        break;
                }

                if (uCent == 1 && dCent == 0)
                {
                    result += "centavo";
                }
                else
                {
                    result += "centavos";
                }
            }
            return result;
        }
    }
}
