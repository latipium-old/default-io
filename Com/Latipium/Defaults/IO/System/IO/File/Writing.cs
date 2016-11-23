// Writing.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using System.Text;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		[LatipiumMethod("WriteAllBytes")]
		public void WriteAllBytes(string path, byte[] bytes) {
			if ( BeforeOperation(path) ) {
				try {
					File.WriteAllBytes(path, bytes);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("WriteAllLines")]
		public void WriteAllLines(string path, string[] lines) {
			if ( BeforeOperation(path) ) {
				try {
					File.WriteAllLines(path, lines);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("WriteAllLines")]
		public void WriteAllLines(string path, string[] lines, Encoding encoding) {
			if ( BeforeOperation(path) ) {
				try {
					File.WriteAllLines(path, lines, encoding);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("WriteAllText")]
		public void WriteAllText(string path, string text) {
			if ( BeforeOperation(path) ) {
				try {
					File.WriteAllText(path, text);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("WriteAllText")]
		public void WriteAllText(string path, string text, Encoding encoding) {
			if ( BeforeOperation(path) ) {
				try {
					File.WriteAllText(path, text, encoding);
				} finally {
					AfterOperation();
				}
			}
		}
	}
}

