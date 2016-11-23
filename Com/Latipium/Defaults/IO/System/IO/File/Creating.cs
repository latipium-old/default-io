// Creating.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using System.Security.AccessControl;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		[LatipiumMethod("Create")]
		public FileStream Create(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Create(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("Create")]
		public FileStream Create(string path, int bufferSize) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Create(path, bufferSize);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("Create")]
		public FileStream Create(string path, int bufferSize, FileOptions options) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Create(path, bufferSize, options);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("Create")]
		public FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity security) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Create(path, bufferSize, options, security);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("CreateText")]
		public StreamWriter CreateText(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.CreateText(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}
	}
}

