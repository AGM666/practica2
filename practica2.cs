/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 28/02/2014
 * Time: 12:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica2
{
	class Precios
	{
		public static void Main(string[] args){
			
	       double iva = 1.16;
		   double precio1,precio2,precio3;
		   
		   Console.WriteLine("ingresa primer valor");
		   float primero=float.Parse (Console.ReadLine());
		   
		     Console.WriteLine("ingresa segundo valor");
		     float segundo=float.Parse (Console.ReadLine());
		      
		     Console.WriteLine("ingresa tercer valor");
		     float tercero=float.Parse (Console.ReadLine());
		     
		     
		     
		     
		     precio1 = primero * iva;
		     precio2 = segundo * iva;
		     precio3 = tercero * iva;
		     
		     Console.WriteLine("precio 1 es:"+ precio1);
		     Console.WriteLine("precio 2 es:"+ precio2);
		     Console.WriteLine("precio 3 es:"+ precio3);
		     
		     
		
		
			
			// TODO: Implement Functionality Here
			
			
		}
	}
}