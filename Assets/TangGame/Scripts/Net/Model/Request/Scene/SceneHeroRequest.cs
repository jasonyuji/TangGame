﻿/*
 * Created by SharpDevelop.
 * User: zzc
 * Date: 2013/5/24
 * Time: 19:41
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using TangNet;

namespace TangGame.Net
{
/// <summary>
/// Description of SceneHeroRequest.
/// </summary>
public class SceneHeroRequest : Request
{
    public NetData NetData
    {
        get
        {
            return new NetData(SceneProxy.S_GET_HERO);
        }
    }
}
}
