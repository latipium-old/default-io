// Appending.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using System.Text;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		[LatipiumMethod("AppendAllText")]
		public void AppendAllText(string path, string contents) {
			if ( BeforeOperation(path) ) {
				try {
					File.AppendAllText(path, contents);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("AppendAllText")]
		public void AppendAllText(string path, string contents, Encoding encoding) {
			if ( BeforeOperation(path) ) {
				try {
					File.AppendAllText(path, contents, encoding);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("AppendText")]
		public StreamWriter AppendText(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.AppendText(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}
	}
}

