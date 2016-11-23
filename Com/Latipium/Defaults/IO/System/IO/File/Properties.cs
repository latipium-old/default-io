// Properties.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using System.Security.AccessControl;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		[LatipiumMethod("Exists")]
		public bool Exists(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Exists(path);
				} finally {
					AfterOperation();
				}
			}
			return false;
		}

		[LatipiumMethod("GetAccessControl")]
		public FileSecurity GetAccessControl(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.GetAccessControl(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("GetAccessControl")]
		public FileSecurity GetAccessControl(string path, AccessControlSections includeSections) {
			if ( BeforeOperation(path) ) {
				try {
					return File.GetAccessControl(path, includeSections);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

		[LatipiumMethod("GetAttributes")]
		public FileAttributes GetAttributes(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.GetAttributes(path);
				} finally {
					AfterOperation();
				}
			}
			return default(FileAttributes);
		}

		[LatipiumMethod("GetCreationTime")]
		public DateTime GetCreationTime(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.GetCreationTime(path);
				} finally {
					AfterOperation();
				}
			}
			return default(DateTime);
		}

		[LatipiumMethod("GetCreationTimeUtc")]
		public DateTime GetCreationTimeUtc(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.GetCreationTimeUtc(path);
				} finally {
					AfterOperation();
				}
			}
			return default(DateTime);
		}

		[LatipiumMethod("GetLastAccessTime")]
		public DateTime GetLastAccessTime(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.GetLastAccessTime(path);
				} finally {
					AfterOperation();
				}
			}
			return default(DateTime);
		}

		[LatipiumMethod("GetLastAccessTimeUtc")]
		public DateTime GetLastAccessTimeUtc(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.GetLastAccessTimeUtc(path);
				} finally {
					AfterOperation();
				}
			}
			return default(DateTime);
		}

		[LatipiumMethod("GetLastWriteTime")]
		public DateTime GetLastWriteTime(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.GetLastWriteTime(path);
				} finally {
					AfterOperation();
				}
			}
			return default(DateTime);
		}

		[LatipiumMethod("GetLastWriteTimeUtc")]
		public DateTime GetLastWriteTimeUtc(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.GetLastWriteTimeUtc(path);
				} finally {
					AfterOperation();
				}
			}
			return default(DateTime);
		}

		[LatipiumMethod("SetAccessControl")]
		public void SetAccessControl(string path, FileSecurity fileSecurity) {
			if ( BeforeOperation(path) ) {
				try {
					File.SetAccessControl(path, fileSecurity);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("SetAttributes")]
		public void SetAttributes(string path, FileAttributes fileAttributes) {
			if ( BeforeOperation(path) ) {
				try {
					File.SetAttributes(path, fileAttributes);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("SetCreationTime")]
		public void SetCreationTime(string path, DateTime creationTime) {
			if ( BeforeOperation(path) ) {
				try {
					File.SetCreationTime(path, creationTime);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("SetCreationTimeUtc")]
		public void SetCreationTimeUtc(string path, DateTime creationTimeUtc) {
			if ( BeforeOperation(path) ) {
				try {
					File.SetCreationTimeUtc(path, creationTimeUtc);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("SetLastAccessTime")]
		public void SetLastAccessTime(string path, DateTime lastAccessTime) {
			if ( BeforeOperation(path) ) {
				try {
					File.SetLastAccessTime(path, lastAccessTime);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("SetLastAccessTimeUtc")]
		public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) {
			if ( BeforeOperation(path) ) {
				try {
					File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("SetLastWriteTime")]
		public void SetLastWriteTime(string path, DateTime lastWriteTime) {
			if ( BeforeOperation(path) ) {
				try {
					File.SetLastWriteTime(path, lastWriteTime);
				} finally {
					AfterOperation();
				}
			}
		}

		[LatipiumMethod("SetLastWriteTimeUtc")]
		public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) {
			if ( BeforeOperation(path) ) {
				try {
					File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
				} finally {
					AfterOperation();
				}
			}
		}
	}
}

