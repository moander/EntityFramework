// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.FunctionalTests.TestModels.Inheritance
{
    public abstract class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
