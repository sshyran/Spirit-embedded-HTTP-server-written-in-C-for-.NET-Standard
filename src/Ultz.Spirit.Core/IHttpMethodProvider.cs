// 
// IHttpMethodProvider.cs
// 
// Copyright (C) 2019 Ultz Limited
// 
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
// 

namespace Ultz.Spirit.Core
{
    public interface IHttpMethodProvider
    {
        HttpMethods Provide(string name);
    }
}
