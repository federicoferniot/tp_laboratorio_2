﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class TrackingIdRepetidoException: Exception
	{
		public TrackingIdRepetidoException() : base("Tracking ID está repetido")
		{
		}
	}
}
