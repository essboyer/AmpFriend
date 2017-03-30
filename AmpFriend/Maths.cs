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
		
		public static decimal findPFromRMS(decimal rmsVolts, double load)
		{
			return Math.Round( (rmsVolts * rmsVolts) / Convert.ToDecimal(load), 3);
		}
		
		public static decimal findPFromPeak(decimal peakVolts, double load)
		{
			double d = Convert.ToDouble(peakVolts);
			double rmsVolts = peak2RMS(d);
			
			return Convert.ToDecimal(findPFromRMS(Convert.ToDecimal(rmsVolts), load));
		}
		
		public static double findRMSFromP(double p, double load)
		{
			return Math.Round(Math.Sqrt(p * load), 3);
		}
		
		public static double peak2RMS(double peakVolts) 
		{
			return Math.Round(0.3535 * peakVolts);
		}
		
		public static double rms2Peak(double rmsVolts) 
		{
			return Math.Round(rmsVolts * (1.414 * 2));
		}
	}

}
