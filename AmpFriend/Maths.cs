/*
 * Created by SharpDevelop.
 * User: boyer
 * Date: 12/6/2013
 * Time: 8:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AmpFriend
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Maths
	{
		public Maths()
		{
		}
		
		public static decimal findPFromRMS(decimal rmsVolts, decimal load)
		{
			return Math.Round( (rmsVolts * rmsVolts) / load, 3);
		}
		
		public static double findRMSFromP(double p, double load)
		{
			return Math.Round(Math.Sqrt(p * load), 3);
		}
		
	}

}
