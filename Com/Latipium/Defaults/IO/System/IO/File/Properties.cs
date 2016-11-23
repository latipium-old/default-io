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
        /// <summary>
        /// See File.Exists
        /// </summary>
        /// <param name="path">Path.</param>
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

        /// <summary>
        /// See File.GetAccessControl
        /// </summary>
        /// <returns>The access control.</returns>
        /// <param name="path">Path.</param>
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

        /// <summary>
        /// See File.GetAccessControl
        /// </summary>
        /// <returns>The access control.</returns>
        /// <param name="path">Path.</param>
        /// <param name="includeSections">Include sections.</param>
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

        /// <summary>
        /// See File.GetAttributes
        /// </summary>
        /// <returns>The attributes.</returns>
        /// <param name="path">Path.</param>
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

        /// <summary>
        /// See File.GetCreationTime
        /// </summary>
        /// <returns>The creation time.</returns>
        /// <param name="path">Path.</param>
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

        /// <summary>
        /// See File.GetCreationTimeUtc
        /// </summary>
        /// <returns>The creation time UTC.</returns>
        /// <param name="path">Path.</param>
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

        /// <summary>
        /// See File.GetLastAccessTime
        /// </summary>
        /// <returns>The last access time.</returns>
        /// <param name="path">Path.</param>
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

        /// <summary>
        /// See File.GetLastAccessTimeUtc
        /// </summary>
        /// <returns>The last access time UTC.</returns>
        /// <param name="path">Path.</param>
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

        /// <summary>
        /// See File.GetLastWriteTime
        /// </summary>
        /// <returns>The last write time.</returns>
        /// <param name="path">Path.</param>
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

        /// <summary>
        /// See File.GetLastWriteTimeUtc
        /// </summary>
        /// <returns>The last write time UTC.</returns>
        /// <param name="path">Path.</param>
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

        /// <summary>
        /// See File.SetAccessControl
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="fileSecurity">File security.</param>
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

        /// <summary>
        /// See File.SetAttributes
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="fileAttributes">File attributes.</param>
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

        /// <summary>
        /// See File.SetCreationTime
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="creationTime">Creation time.</param>
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

        /// <summary>
        /// See File.SetCreationTimeUtc
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="creationTimeUtc">Creation time UTC.</param>
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

        /// <summary>
        /// See File.SetLastAccessTime
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="lastAccessTime">Last access time.</param>
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

        /// <summary>
        /// See File.SetLastAccessTimeUtc
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="lastAccessTimeUtc">Last access time UTC.</param>
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

        /// <summary>
        /// See File.SetLastWriteTime
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="lastWriteTime">Last write time.</param>
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

        /// <summary>
        /// See File.SetLastWriteTimeUtc
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="lastWriteTimeUtc">Last write time UTC.</param>
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

