// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.ChangeTracking.Internal;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Internal;
using Microsoft.Data.Entity.Query;
using Microsoft.Data.Entity.Relational.Query;
using Microsoft.Data.Entity.Relational.Query.Expressions;
using Microsoft.Data.Entity.Relational.Query.Methods;
using Microsoft.Data.Entity.Relational.Query.Sql;
using Microsoft.Framework.Logging;

namespace Microsoft.Data.Entity.Sqlite.Query
{
    public class SqliteQueryCompilationContext : RelationalQueryCompilationContext
    {
        public SqliteQueryCompilationContext(
            [NotNull] IModel model,
            [NotNull] ILogger logger,
            [NotNull] ILinqOperatorProvider linqOperatorProvider,
            [NotNull] IResultOperatorHandler resultOperatorHandler,
            [NotNull] IEntityMaterializerSource entityMaterializerSource,
            [NotNull] IClrAccessorSource<IClrPropertyGetter> clrPropertyGetterSource,
            [NotNull] IEntityKeyFactorySource entityKeyFactorySource,
            [NotNull] IQueryMethodProvider queryMethodProvider,
            [NotNull] IMethodCallTranslator methodCallTranslator,
            [NotNull] ISqliteValueBufferFactoryFactory valueBufferFactoryFactory)
            : base(
                  model,
                  logger,
                  linqOperatorProvider,
                  resultOperatorHandler,
                  entityMaterializerSource,
                  entityKeyFactorySource,
                  clrPropertyGetterSource,
                  queryMethodProvider,
                  methodCallTranslator,
                  valueBufferFactoryFactory)
        {
        }

        public override ISqlQueryGenerator CreateSqlQueryGenerator(SelectExpression selectExpression) =>
            new SqliteQueryGenerator(selectExpression);
    }
}
