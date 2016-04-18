// Reading.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using System.Text;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		[LatipiumMethod("ReadAllBytes")]
		public byte[] ReadAllBytes(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllBytes(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("ReadAllLines")]
		public string[] ReadAllLines(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllLines(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("ReadAllLines")]
		public string[] ReadAllLines(string path, Encoding encoding) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllLines(path, encoding);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("ReadAllText")]
		public string ReadAllText(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllText(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("ReadAllText")]
		public string ReadAllText(string path, Encoding encoding) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllText(path, encoding);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}
	}
}

