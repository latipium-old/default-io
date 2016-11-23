// Manipulation.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		[LatipiumMethod("Copy")]
		public void Copy(string sourceFileName, string destFileName) {
			if ( BeforeOperation(sourceFileName, destFileName) ) {
				try {
					File.Copy(sourceFileName, destFileName);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("Copy")]
		public void Copy(string sourceFileName, string destFileName, bool overwrite) {
			if ( BeforeOperation(sourceFileName, destFileName) ) {
				try {
					File.Copy(sourceFileName, destFileName, overwrite);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("Delete")]
		public void Delete(string path) {
			if ( BeforeOperation(path) ) {
				try {
					File.Delete(path);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("Move")]
		public void Move(string sourceFileName, string destFileName) {
			if ( BeforeOperation(sourceFileName, destFileName) ) {
				try {
					File.Move(sourceFileName, destFileName);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("Replace")]
		public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName) {
			if ( BeforeOperation(sourceFileName, destinationFileName, destinationBackupFileName) ) {
				try {
					File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("Replace")]
		public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) {
			if ( BeforeOperation(sourceFileName, destinationFileName, destinationBackupFileName) ) {
				try {
					File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
				} finally {
					AfterOperation();
				}
			}
		}
	}
}

