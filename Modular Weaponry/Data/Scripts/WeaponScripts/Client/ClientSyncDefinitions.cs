﻿using ProtoBuf;
using VRage;
using VRage.Game.Entity;
using VRageMath;

namespace Modular_Weaponry.Data.Scripts.WeaponScripts.Client
{
    internal class ClientSyncDefinitions
    {
        [ProtoContract]
        public class ProjectileContainer
        {
            public ProjectileContainer() { }

            public ProjectileContainer(long firerId, MyTuple<bool, Vector3D, Vector3D, float> projectileData, long time)
            {
                this.FirerId = firerId;
                this.ProjectileData = projectileData;
                Time = time;
            }

            [ProtoMember(1)] public long FirerId { get; set; }
            [ProtoMember(2)] public MyTuple<bool, Vector3D, Vector3D, float> ProjectileData { get; set; }
            [ProtoMember(3)] public long Time { get; set; }
        }
    }
}
