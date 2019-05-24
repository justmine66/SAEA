/* Copyright 2013-present MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
#if NET452
using System.Runtime.Serialization;
#endif
using SAEA.Mongo.Bson;
using SAEA.Mongo.Driver.Core.Connections;

namespace SAEA.Mongo.Driver
{
    /// <summary>
    /// Represents a MongoDB not primary exception.
    /// </summary>
#if NET452
    [Serializable]
#endif
    public class MongoNotPrimaryException : MongoCommandException
    {
        // constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoNotPrimaryException"/> class.
        /// </summary>
        /// <param name="connectionId">The connection identifier.</param>
        /// <param name="command">The command.</param>
        /// <param name="result">The result.</param>
        public MongoNotPrimaryException(ConnectionId connectionId, BsonDocument command, BsonDocument result)
            : base(connectionId, "Server returned not master error.", command, result)
        {
        }

#if NET452
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoNotPrimaryException"/> class.
        /// </summary>
        /// <param name="info">The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        protected MongoNotPrimaryException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}