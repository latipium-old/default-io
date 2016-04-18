// Openning.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		[LatipiumMethod("Open")]
		public FileStream Open(string path, FileMode mode) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Open(path, mode);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("Open")]
		public FileStream Open(string path, FileMode mode, FileAccess access) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Open(path, mode, access);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("Open")]
		public FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Open(path, mode, access, share);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("OpenRead")]
		public FileStream OpenRead(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.OpenRead(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("OpenText")]
		public StreamReader OpenText(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.OpenText(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("OpenWrite")]
		public FileStream OpenWrite(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.OpenWrite(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}
	}
}

