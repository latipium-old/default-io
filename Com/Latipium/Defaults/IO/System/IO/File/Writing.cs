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
        /// <summary>
        /// See File.WriteAllBytes
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="bytes">Bytes.</param>
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

        /// <summary>
        /// See File.WriteAllLines
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="lines">Lines.</param>
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

        /// <summary>
        /// See File.WriteAllLines
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="lines">Lines.</param>
        /// <param name="encoding">Encoding.</param>
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

        /// <summary>
        /// See File.WriteAllText
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="text">Text.</param>
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

        /// <summary>
        /// See File.WriteAllText
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="text">Text.</param>
        /// <param name="encoding">Encoding.</param>
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

