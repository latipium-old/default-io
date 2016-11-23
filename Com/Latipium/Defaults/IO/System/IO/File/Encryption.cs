// Encryption.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		[LatipiumMethod("Decrypt")]
		public void Decrypt(string path) {
			if ( BeforeOperation(path) ) {
				try {
					File.Decrypt(path);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("Encrypt")]
		public void Encrypt(string path) {
			if ( BeforeOperation(path) ) {
				try {
					File.Encrypt(path);
				} finally {
					AfterOperation();
				}
			}
		}
	}
}

