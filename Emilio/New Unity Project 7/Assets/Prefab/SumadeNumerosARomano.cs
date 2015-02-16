using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SumadeNumerosARomano : MonoBehaviour 
{


	public int sumando1; 
	public int sumando2;
	int resultadoDeLaSuma;
	string resultadoDeLaSumaConvertidaARomano;
	
	void Start()
	{ 
		resultadoDeLaSuma = sumarNumeros();
		detectarErrores (resultadoDeLaSuma);
	}

	public int sumarNumeros ()
	{
		resultadoDeLaSuma = sumando1 + sumando2;
		return resultadoDeLaSuma;
	}

	public void detectarErrores (int resultadoDeLaSuma)
	{
		if (resultadoDeLaSuma < 1 || resultadoDeLaSuma > 3999) 
		{ 
			errorDetectedAndMessage ();
		} 
		else 
		{
			resultadoDeLaSumaConvertidaARomano = convertirDeRomanoADecimal (resultadoDeLaSuma);
			mostrarResultadoDeLaConversionARomano ();
		}

	}

	public void errorDetectedAndMessage ()

	{ 
		Debug.Log ("El numero no puede ser convertido a numero romano");
	}

	public string convertirDeRomanoADecimal (int resultadoDeLaSuma)
	{
		int [] arrayNumerosDecimales = new int[] {1000, 900, 500, 400, 100, 90, 50, 40, 10 ,9, 5, 4, 1};
		string [] arrayNumerosRomanos = new string [] {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
		int i;
		for(i=0; i<arrayNumerosRomanos.Length; i++)
			{
				while (resultadoDeLaSuma >= arrayNumerosDecimales[i])
				{
					resultadoDeLaSuma -= arrayNumerosDecimales[i];
				resultadoDeLaSumaConvertidaARomano += arrayNumerosRomanos[i];
				}
			}
		return resultadoDeLaSumaConvertidaARomano;
	}
	

	public void mostrarResultadoDeLaConversionARomano ()
	{
		Debug.Log("El numero en romanos de la suma  de "+sumando1+" + "+sumando2+" es: "+resultadoDeLaSumaConvertidaARomano);
	}

}

