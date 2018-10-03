using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#if NET35
using systemAlias = global::KRPC.Client.Compatibility;
using genericCollectionsAlias = global::KRPC.Client.Compatibility;
#else
using systemAlias = global::System;
using genericCollectionsAlias = global::System.Collections.Generic;
#endif

namespace KRPC.Client.Services.MechJeb
{
    /// <summary>
    /// Extension methods for MechJeb service.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Create an instance of the MechJeb service.
        /// </summary>
        public static global::KRPC.Client.Services.MechJeb.Service MechJeb (this global::KRPC.Client.IConnection connection)
        {
            return new global::KRPC.Client.Services.MechJeb.Service (connection);
        }
    }

    /// <summary>
    /// MechJeb service.
    /// </summary>
    public class Service
    {
        global::KRPC.Client.IConnection connection;

        internal Service (global::KRPC.Client.IConnection serverConnection)
        {
            connection = serverConnection;
            AddExceptionTypes (serverConnection);
        }

        internal static void AddExceptionTypes (global::KRPC.Client.IConnection serverConnection)
        {
            serverConnection.AddExceptionType ("MechJeb", "MJServiceException", typeof (MJServiceException));
            serverConnection.AddExceptionType ("MechJeb", "OperationException", typeof (OperationException));
        }

        /// <summary>
        /// A value indicating whether the service is available.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_APIReady")]
        public bool APIReady {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_APIReady");
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_AirplaneAutopilot")]
        public global::KRPC.Client.Services.MechJeb.AirplaneAutopilot AirplaneAutopilot {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_AirplaneAutopilot");
                return (global::KRPC.Client.Services.MechJeb.AirplaneAutopilot)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.AirplaneAutopilot), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_AntennaController")]
        public global::KRPC.Client.Services.MechJeb.DeployableController AntennaController {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_AntennaController");
                return (global::KRPC.Client.Services.MechJeb.DeployableController)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.DeployableController), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_AscentAutopilot")]
        public global::KRPC.Client.Services.MechJeb.AscentAutopilot AscentAutopilot {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_AscentAutopilot");
                return (global::KRPC.Client.Services.MechJeb.AscentAutopilot)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.AscentAutopilot), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_DockingAutopilot")]
        public global::KRPC.Client.Services.MechJeb.DockingAutopilot DockingAutopilot {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_DockingAutopilot");
                return (global::KRPC.Client.Services.MechJeb.DockingAutopilot)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.DockingAutopilot), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_LandingAutopilot")]
        public global::KRPC.Client.Services.MechJeb.LandingAutopilot LandingAutopilot {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_LandingAutopilot");
                return (global::KRPC.Client.Services.MechJeb.LandingAutopilot)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.LandingAutopilot), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_ManeuverPlanner")]
        public global::KRPC.Client.Services.MechJeb.ManeuverPlanner ManeuverPlanner {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_ManeuverPlanner");
                return (global::KRPC.Client.Services.MechJeb.ManeuverPlanner)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.ManeuverPlanner), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_NodeExecutor")]
        public global::KRPC.Client.Services.MechJeb.NodeExecutor NodeExecutor {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_NodeExecutor");
                return (global::KRPC.Client.Services.MechJeb.NodeExecutor)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.NodeExecutor), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_RCSController")]
        public global::KRPC.Client.Services.MechJeb.RCSController RCSController {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_RCSController");
                return (global::KRPC.Client.Services.MechJeb.RCSController)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.RCSController), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_RendezvousAutopilot")]
        public global::KRPC.Client.Services.MechJeb.RendezvousAutopilot RendezvousAutopilot {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_RendezvousAutopilot");
                return (global::KRPC.Client.Services.MechJeb.RendezvousAutopilot)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.RendezvousAutopilot), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_SmartRCS")]
        public global::KRPC.Client.Services.MechJeb.SmartRCS SmartRCS {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_SmartRCS");
                return (global::KRPC.Client.Services.MechJeb.SmartRCS)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.SmartRCS), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_SolarPanelController")]
        public global::KRPC.Client.Services.MechJeb.DeployableController SolarPanelController {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_SolarPanelController");
                return (global::KRPC.Client.Services.MechJeb.DeployableController)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.DeployableController), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_StagingController")]
        public global::KRPC.Client.Services.MechJeb.StagingController StagingController {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_StagingController");
                return (global::KRPC.Client.Services.MechJeb.StagingController)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.StagingController), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_TargetController")]
        public global::KRPC.Client.Services.MechJeb.TargetController TargetController {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_TargetController");
                return (global::KRPC.Client.Services.MechJeb.TargetController)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TargetController), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "get_ThrustController")]
        public global::KRPC.Client.Services.MechJeb.ThrustController ThrustController {
            get {
                ByteString _data = connection.Invoke ("MechJeb", "get_ThrustController");
                return (global::KRPC.Client.Services.MechJeb.ThrustController)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.ThrustController), connection);
            }
        }
    }

    [Serializable]
    public enum DifferentialThrottleStatus
    {
        Success = 0,
        AllEnginesOff = 1,
        MoreEnginesRequired = 2,
        SolverFailed = 3
    }

    [Serializable]
    public enum SmartRCSMode
    {
        Off = 0,
        ZeroRelativeVelocity = 1,
        ZeroVelocity = 2
    }

    [Serializable]
    public enum TimeReference
    {
        Computed = 0,
        XFromNow = 1,
        Apoapsis = 2,
        Periapsis = 3,
        Altitude = 4,
        EqAscending = 5,
        EqDescending = 6,
        RelAscending = 7,
        RelDescending = 8,
        ClosestApproach = 9,
        EqHighestAd = 10,
        EqNearestAd = 11,
        RelHighestAd = 12,
        RelNearestAd = 13
    }

    /// <summary>
    /// General exception for errors in the service.
    /// </summary>
    [Serializable]
    public class MJServiceException : global::KRPC.Client.RPCException
    {
        /// <summary>
        /// Construct an MJServiceException with no message.
        /// </summary>
        public MJServiceException ()
        {
        }

        /// <summary>
        /// Construct an MJServiceException with the given message.
        /// </summary>
        public MJServiceException (string message) : base (message)
        {
        }

        /// <summary>
        /// Construct an MJServiceException with the given message and inner exception.
        /// </summary>
        public MJServiceException (string message, Exception inner) : base (message, inner)
        {
        }

        /// <summary>
        /// Construct an MJServiceException with the given serialization info and streaming context.
        /// </summary>
        protected MJServiceException (SerializationInfo info, StreamingContext context) : base (info, context)
        {
        }
    }

    /// <summary>
    /// This exception is thrown when there is something wrong with the operation (e.g. the target is not set when the operation needs it).
    /// </summary>
    [Serializable]
    public class OperationException : global::KRPC.Client.RPCException
    {
        /// <summary>
        /// Construct an OperationException with no message.
        /// </summary>
        public OperationException ()
        {
        }

        /// <summary>
        /// Construct an OperationException with the given message.
        /// </summary>
        public OperationException (string message) : base (message)
        {
        }

        /// <summary>
        /// Construct an OperationException with the given message and inner exception.
        /// </summary>
        public OperationException (string message, Exception inner) : base (message, inner)
        {
        }

        /// <summary>
        /// Construct an OperationException with the given serialization info and streaming context.
        /// </summary>
        protected OperationException (SerializationInfo info, StreamingContext context) : base (info, context)
        {
        }
    }

    public class AirplaneAutopilot : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public AirplaneAutopilot (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_AccKd")]
        public double AccKd {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_AccKd", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_AccKd", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_AccKi")]
        public double AccKi {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_AccKi", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_AccKi", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_AccKp")]
        public double AccKp {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_AccKp", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_AccKp", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_AltitudeHoldEnabled")]
        public bool AltitudeHoldEnabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_AltitudeHoldEnabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_AltitudeHoldEnabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_AltitudeTarget")]
        public double AltitudeTarget {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_AltitudeTarget", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_AltitudeTarget", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_Enabled")]
        public bool Enabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_Enabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_Enabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_HeadingHoldEnabled")]
        public bool HeadingHoldEnabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_HeadingHoldEnabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_HeadingHoldEnabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_HeadingTarget")]
        public double HeadingTarget {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_HeadingTarget", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_HeadingTarget", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_RolKd")]
        public double RolKd {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_RolKd", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_RolKd", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_RolKi")]
        public double RolKi {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_RolKi", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_RolKi", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_RolKp")]
        public double RolKp {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_RolKp", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_RolKp", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_RollHoldEnabled")]
        public bool RollHoldEnabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_RollHoldEnabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_RollHoldEnabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_RollMax")]
        public double RollMax {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_RollMax", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_RollMax", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_RollTarget")]
        public double RollTarget {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_RollTarget", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_RollTarget", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_SpeedHoldEnabled")]
        public bool SpeedHoldEnabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_SpeedHoldEnabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_SpeedHoldEnabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_SpeedTarget")]
        public double SpeedTarget {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_SpeedTarget", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_SpeedTarget", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_VerKd")]
        public double VerKd {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_VerKd", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_VerKd", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_VerKi")]
        public double VerKi {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_VerKi", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_VerKi", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_VerKp")]
        public double VerKp {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_VerKp", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_VerKp", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_VertSpeedHoldEnabled")]
        public bool VertSpeedHoldEnabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_VertSpeedHoldEnabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_VertSpeedHoldEnabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_VertSpeedMax")]
        public double VertSpeedMax {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_VertSpeedMax", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_VertSpeedMax", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_VertSpeedTarget")]
        public double VertSpeedTarget {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_VertSpeedTarget", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_VertSpeedTarget", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_YawKd")]
        public double YawKd {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_YawKd", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_YawKd", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_YawKi")]
        public double YawKi {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_YawKi", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_YawKi", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_YawKp")]
        public double YawKp {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_YawKp", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_YawKp", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AirplaneAutopilot_get_YawLimit")]
        public double YawLimit {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AirplaneAutopilot_get_YawLimit", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AirplaneAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AirplaneAutopilot_set_YawLimit", _args);
            }
        }
    }

    /// <summary>
    /// This module controls the Ascent Guidance in MechJeb 2.
    /// </summary>
    public class AscentAutopilot : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public AscentAutopilot (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_LaunchToRendezvous")]
        public void LaunchToRendezvous ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
            };
            connection.Invoke ("MechJeb", "AscentAutopilot_LaunchToRendezvous", _args);
        }

        /// <summary>
        /// Launch into the plane of the selected target.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_LaunchToTargetPlane")]
        public void LaunchToTargetPlane ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
            };
            connection.Invoke ("MechJeb", "AscentAutopilot_LaunchToTargetPlane", _args);
        }

        /// <summary>
        /// The pressure value when AoA limit is automatically deactivated.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_AoALimitFadeoutPressure")]
        public double AoALimitFadeoutPressure {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_AoALimitFadeoutPressure", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_AoALimitFadeoutPressure", _args);
            }
        }

        /// <summary>
        /// Get Classic Ascent Profile settings.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_AscentPathClassic")]
        public global::KRPC.Client.Services.MechJeb.AscentClassic AscentPathClassic {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_AscentPathClassic", _args);
                return (global::KRPC.Client.Services.MechJeb.AscentClassic)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.AscentClassic), connection);
            }
        }

        /// <summary>
        /// Get Stock-style GravityTurn profile settings.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_AscentPathGT")]
        public global::KRPC.Client.Services.MechJeb.AscentGT AscentPathGT {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_AscentPathGT", _args);
                return (global::KRPC.Client.Services.MechJeb.AscentGT)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.AscentGT), connection);
            }
        }

        /// <summary>
        /// The selected ascent path.
        ///
        /// 0 = <see cref="T:MechJeb.AscentClassic" /> (Classic Ascent Profile)
        ///
        /// 1 = <see cref="T:MechJeb.AscentGT" /> (Stock-style GravityTurn)
        ///
        /// 2 = <see cref="T:MechJeb.AscentPEG" /> (Powered Explicit Guidance (RSS/RO))
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_AscentPathIndex")]
        public int AscentPathIndex {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_AscentPathIndex", _args);
                return (int)global::KRPC.Client.Encoder.Decode (_data, typeof(int), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(int))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_AscentPathIndex", _args);
            }
        }

        /// <summary>
        /// Get Powered Explicit Guidance (RSS/RO) profile settings.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_AscentPathPEG")]
        public global::KRPC.Client.Services.MechJeb.AscentPEG AscentPathPEG {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_AscentPathPEG", _args);
                return (global::KRPC.Client.Services.MechJeb.AscentPEG)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.AscentPEG), connection);
            }
        }

        /// <summary>
        /// Whether to deploy antennas automatically when the ascent finishes.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_AutoDeployAntennas")]
        public bool AutoDeployAntennas {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_AutoDeployAntennas", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_AutoDeployAntennas", _args);
            }
        }

        /// <summary>
        /// Whether to deploy solar panels automatically when the ascent finishes.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_AutodeploySolarPanels")]
        public bool AutodeploySolarPanels {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_AutodeploySolarPanels", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_AutodeploySolarPanels", _args);
            }
        }

        /// <summary>
        /// Whether to enable autostaging. Paramethers can be set in <see cref="T:MechJeb.StagingController" />.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_Autostage")]
        public bool Autostage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_Autostage", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_Autostage", _args);
            }
        }

        /// <summary>
        /// The state of corrective steering.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_CorrectiveSteering")]
        public bool CorrectiveSteering {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_CorrectiveSteering", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_CorrectiveSteering", _args);
            }
        }

        /// <summary>
        /// The gain of corrective steering used by the autopilot.
        /// </summary>
        /// <remarks><see cref="M:MechJeb.AscentAutopilot.CorrectiveSteering" /> needs to be enabled.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_CorrectiveSteeringGain")]
        public double CorrectiveSteeringGain {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_CorrectiveSteeringGain", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_CorrectiveSteeringGain", _args);
            }
        }

        /// <summary>
        /// The desired inclination.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_DesiredInclination")]
        public double DesiredInclination {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_DesiredInclination", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_DesiredInclination", _args);
            }
        }

        /// <summary>
        /// The desired orbit altitude.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_DesiredOrbitAltitude")]
        public double DesiredOrbitAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_DesiredOrbitAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_DesiredOrbitAltitude", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_Enabled")]
        public bool Enabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_Enabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_Enabled", _args);
            }
        }

        /// <summary>
        /// The state of force roll.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_ForceRoll")]
        public bool ForceRoll {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_ForceRoll", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_ForceRoll", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_LaunchLANDifference")]
        public double LaunchLANDifference {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_LaunchLANDifference", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_LaunchLANDifference", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_LaunchPhaseAngle")]
        public double LaunchPhaseAngle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_LaunchPhaseAngle", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_LaunchPhaseAngle", _args);
            }
        }

        /// <summary>
        /// Whether to limit angle of attack.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_LimitAoA")]
        public bool LimitAoA {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_LimitAoA", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_LimitAoA", _args);
            }
        }

        /// <summary>
        /// The maximal angle of attack used by the autopilot.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_MaxAoA")]
        public double MaxAoA {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_MaxAoA", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_MaxAoA", _args);
            }
        }

        /// <summary>
        /// Whether to skip circularization burn and do only the ascent.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_SkipCircularization")]
        public bool SkipCircularization {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_SkipCircularization", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_SkipCircularization", _args);
            }
        }

        /// <remarks>Equivalent to <see cref="M:MechJeb.StagingController" />.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_StagingController")]
        public global::KRPC.Client.Services.MechJeb.StagingController StagingController {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_StagingController", _args);
                return (global::KRPC.Client.Services.MechJeb.StagingController)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.StagingController), connection);
            }
        }

        /// <summary>
        /// The autopilot status; it depends on the selected ascent path.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_Status")]
        public string Status {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_Status", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        /// <remarks>Equivalend to <see cref="M:MechJeb.ThrustController" />.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_ThrustController")]
        public global::KRPC.Client.Services.MechJeb.ThrustController ThrustController {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_ThrustController", _args);
                return (global::KRPC.Client.Services.MechJeb.ThrustController)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.ThrustController), connection);
            }
        }

        /// <summary>
        /// The turn roll used by the autopilot.
        /// </summary>
        /// <remarks><see cref="M:MechJeb.AscentAutopilot.ForceRoll" /> needs to be enabled.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_TurnRoll")]
        public double TurnRoll {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_TurnRoll", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_TurnRoll", _args);
            }
        }

        /// <summary>
        /// The vertical/climb roll used by the autopilot.
        /// </summary>
        /// <remarks><see cref="M:MechJeb.AscentAutopilot.ForceRoll" /> needs to be enabled.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_VerticalRoll")]
        public double VerticalRoll {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_VerticalRoll", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_VerticalRoll", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentAutopilot_get_WarpCountDown")]
        public int WarpCountDown {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentAutopilot_get_WarpCountDown", _args);
                return (int)global::KRPC.Client.Encoder.Decode (_data, typeof(int), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(int))
                };
                connection.Invoke ("MechJeb", "AscentAutopilot_set_WarpCountDown", _args);
            }
        }
    }

    /// <summary>
    /// The Classic Ascent Profile.
    /// </summary>
    public class AscentClassic : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public AscentClassic (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Whether to enable automatic altitude turn.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_AutoPath")]
        public bool AutoPath {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_AutoPath", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "AscentClassic_set_AutoPath", _args);
            }
        }

        /// <summary>
        /// A value between 0 and 1.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_AutoPathPerc")]
        public float AutoPathPerc {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_AutoPathPerc", _args);
                return (float)global::KRPC.Client.Encoder.Decode (_data, typeof(float), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(float))
                };
                connection.Invoke ("MechJeb", "AscentClassic_set_AutoPathPerc", _args);
            }
        }

        /// <summary>
        /// A value between 0 and 1.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_AutoPathSpeedFactor")]
        public float AutoPathSpeedFactor {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_AutoPathSpeedFactor", _args);
                return (float)global::KRPC.Client.Encoder.Decode (_data, typeof(float), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(float))
                };
                connection.Invoke ("MechJeb", "AscentClassic_set_AutoPathSpeedFactor", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_AutoTurnEndAltitude")]
        public double AutoTurnEndAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_AutoTurnEndAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_AutoTurnStartAltitude")]
        public double AutoTurnStartAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_AutoTurnStartAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_AutoTurnStartVelocity")]
        public double AutoTurnStartVelocity {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_AutoTurnStartVelocity", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
        }

        /// <summary>
        /// The turn ends when this altitude is reached.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_TurnEndAltitude")]
        public double TurnEndAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_TurnEndAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentClassic_set_TurnEndAltitude", _args);
            }
        }

        /// <summary>
        /// The final flight path angle.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_TurnEndAngle")]
        public double TurnEndAngle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_TurnEndAngle", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentClassic_set_TurnEndAngle", _args);
            }
        }

        /// <summary>
        /// A value between 0 - 1 describing how steep the turn is.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_TurnShapeExponent")]
        public double TurnShapeExponent {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_TurnShapeExponent", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentClassic_set_TurnShapeExponent", _args);
            }
        }

        /// <summary>
        /// The turn starts when this altitude is reached.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_TurnStartAltitude")]
        public double TurnStartAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_TurnStartAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentClassic_set_TurnStartAltitude", _args);
            }
        }

        /// <summary>
        /// The turn starts when this velocity is reached.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentClassic_get_TurnStartVelocity")]
        public double TurnStartVelocity {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentClassic_get_TurnStartVelocity", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentClassic)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentClassic_set_TurnStartVelocity", _args);
            }
        }
    }

    public class AscentGT : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public AscentGT (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentGT_get_HoldAPTime")]
        public double HoldAPTime {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentGT_get_HoldAPTime", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentGT_set_HoldAPTime", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentGT_get_IntermediateAltitude")]
        public double IntermediateAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentGT_get_IntermediateAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentGT_set_IntermediateAltitude", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentGT_get_TurnStartAltitude")]
        public double TurnStartAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentGT_get_TurnStartAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentGT_set_TurnStartAltitude", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentGT_get_TurnStartPitch")]
        public double TurnStartPitch {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentGT_get_TurnStartPitch", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentGT_set_TurnStartPitch", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentGT_get_TurnStartVelocity")]
        public double TurnStartVelocity {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentGT_get_TurnStartVelocity", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentGT)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentGT_set_TurnStartVelocity", _args);
            }
        }
    }

    /// <summary>
    /// The Powered Explicit Guidance (RSS/RO) profile (Atlas/Centaur PEG Pitch Program).
    /// </summary>
    public class AscentPEG : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public AscentPEG (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// The target apoapsis in meters.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentPEG_get_DesiredApoapsis")]
        public double DesiredApoapsis {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentPEG_get_DesiredApoapsis", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentPEG_set_DesiredApoapsis", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentPEG_get_EditNumStages")]
        public int EditNumStages {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentPEG_get_EditNumStages", _args);
                return (int)global::KRPC.Client.Encoder.Decode (_data, typeof(int), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(int))
                };
                connection.Invoke ("MechJeb", "AscentPEG_set_EditNumStages", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentPEG_get_PitchEndTime")]
        public double PitchEndTime {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentPEG_get_PitchEndTime", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentPEG_set_PitchEndTime", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentPEG_get_PitchRate")]
        public double PitchRate {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentPEG_get_PitchRate", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentPEG_set_PitchRate", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentPEG_get_PitchStartTime")]
        public double PitchStartTime {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentPEG_get_PitchStartTime", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentPEG_set_PitchStartTime", _args);
            }
        }

        /// <summary>
        /// The minimum dV limit for a stage.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentPEG_get_StageLowDVLimit")]
        public double StageLowDVLimit {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentPEG_get_StageLowDVLimit", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentPEG_set_StageLowDVLimit", _args);
            }
        }

        /// <summary>
        /// The terminal guidance period in seconds.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "AscentPEG_get_TerminalGuidanceSecs")]
        public double TerminalGuidanceSecs {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG))
                };
                ByteString _data = connection.Invoke ("MechJeb", "AscentPEG_get_TerminalGuidanceSecs", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.AscentPEG)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "AscentPEG_set_TerminalGuidanceSecs", _args);
            }
        }
    }

    public class DeployableController : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public DeployableController (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DeployableController_AllRetracted")]
        public bool AllRetracted ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DeployableController))
            };
            ByteString _data = connection.Invoke ("MechJeb", "DeployableController_AllRetracted", _args);
            return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DeployableController_ExtendAll")]
        public void ExtendAll ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DeployableController))
            };
            connection.Invoke ("MechJeb", "DeployableController_ExtendAll", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DeployableController_RetractAll")]
        public void RetractAll ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DeployableController))
            };
            connection.Invoke ("MechJeb", "DeployableController_RetractAll", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DeployableController_get_AutoDeploy")]
        public bool AutoDeploy {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DeployableController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DeployableController_get_AutoDeploy", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DeployableController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "DeployableController_set_AutoDeploy", _args);
            }
        }
    }

    public class DockingAutopilot : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public DockingAutopilot (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_Enabled")]
        public bool Enabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_Enabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "DockingAutopilot_set_Enabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_ForceRoll")]
        public bool ForceRoll {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_ForceRoll", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "DockingAutopilot_set_ForceRoll", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_OverrideSafeDistance")]
        public bool OverrideSafeDistance {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_OverrideSafeDistance", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "DockingAutopilot_set_OverrideSafeDistance", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_OverrideTargetSize")]
        public bool OverrideTargetSize {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_OverrideTargetSize", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "DockingAutopilot_set_OverrideTargetSize", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_OverridenSafeDistance")]
        public double OverridenSafeDistance {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_OverridenSafeDistance", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "DockingAutopilot_set_OverridenSafeDistance", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_OverridenTargetSize")]
        public double OverridenTargetSize {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_OverridenTargetSize", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "DockingAutopilot_set_OverridenTargetSize", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_Roll")]
        public double Roll {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_Roll", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "DockingAutopilot_set_Roll", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_SafeDistance")]
        public float SafeDistance {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_SafeDistance", _args);
                return (float)global::KRPC.Client.Encoder.Decode (_data, typeof(float), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_SpeedLimit")]
        public double SpeedLimit {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_SpeedLimit", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "DockingAutopilot_set_SpeedLimit", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_Status")]
        public string Status {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_Status", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "DockingAutopilot_get_TargetSize")]
        public float TargetSize {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.DockingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "DockingAutopilot_get_TargetSize", _args);
                return (float)global::KRPC.Client.Encoder.Decode (_data, typeof(float), connection);
            }
        }
    }

    public class LandingAutopilot : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public LandingAutopilot (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_LandAtPositionTarget")]
        public void LandAtPositionTarget ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
            };
            connection.Invoke ("MechJeb", "LandingAutopilot_LandAtPositionTarget", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_LandUntargeted")]
        public void LandUntargeted ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
            };
            connection.Invoke ("MechJeb", "LandingAutopilot_LandUntargeted", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_StopLanding")]
        public void StopLanding ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
            };
            connection.Invoke ("MechJeb", "LandingAutopilot_StopLanding", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_get_DeployChutes")]
        public bool DeployChutes {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "LandingAutopilot_get_DeployChutes", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "LandingAutopilot_set_DeployChutes", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_get_DeployGears")]
        public bool DeployGears {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "LandingAutopilot_get_DeployGears", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "LandingAutopilot_set_DeployGears", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_get_Enabled")]
        public bool Enabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "LandingAutopilot_get_Enabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "LandingAutopilot_set_Enabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_get_LimitChutesStage")]
        public int LimitChutesStage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "LandingAutopilot_get_LimitChutesStage", _args);
                return (int)global::KRPC.Client.Encoder.Decode (_data, typeof(int), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(int))
                };
                connection.Invoke ("MechJeb", "LandingAutopilot_set_LimitChutesStage", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_get_LimitGearsStage")]
        public int LimitGearsStage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "LandingAutopilot_get_LimitGearsStage", _args);
                return (int)global::KRPC.Client.Encoder.Decode (_data, typeof(int), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(int))
                };
                connection.Invoke ("MechJeb", "LandingAutopilot_set_LimitGearsStage", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_get_RcsAdjustment")]
        public bool RcsAdjustment {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "LandingAutopilot_get_RcsAdjustment", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "LandingAutopilot_set_RcsAdjustment", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_get_Status")]
        public string Status {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "LandingAutopilot_get_Status", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "LandingAutopilot_get_TouchdownSpeed")]
        public double TouchdownSpeed {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "LandingAutopilot_get_TouchdownSpeed", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.LandingAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "LandingAutopilot_set_TouchdownSpeed", _args);
            }
        }
    }

    public class ManeuverPlanner : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public ManeuverPlanner (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationApoapsis")]
        public global::KRPC.Client.Services.MechJeb.OperationApoapsis OperationApoapsis {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationApoapsis", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationApoapsis)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationApoapsis), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationCircularize")]
        public global::KRPC.Client.Services.MechJeb.OperationCircularize OperationCircularize {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationCircularize", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationCircularize)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationCircularize), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationCourseCorrection")]
        public global::KRPC.Client.Services.MechJeb.OperationCourseCorrection OperationCourseCorrection {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationCourseCorrection", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationCourseCorrection)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationCourseCorrection), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationEllipticize")]
        public global::KRPC.Client.Services.MechJeb.OperationEllipticize OperationEllipticize {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationEllipticize", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationEllipticize)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationEllipticize), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationInclination")]
        public global::KRPC.Client.Services.MechJeb.OperationInclination OperationInclination {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationInclination", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationInclination)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationInclination), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationInterplanetaryTransfer")]
        public global::KRPC.Client.Services.MechJeb.OperationInterplanetaryTransfer OperationInterplanetaryTransfer {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationInterplanetaryTransfer", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationInterplanetaryTransfer)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationInterplanetaryTransfer), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationKillRelVel")]
        public global::KRPC.Client.Services.MechJeb.OperationKillRelVel OperationKillRelVel {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationKillRelVel", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationKillRelVel)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationKillRelVel), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationLambert")]
        public global::KRPC.Client.Services.MechJeb.OperationLambert OperationLambert {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationLambert", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationLambert)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationLambert), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationLan")]
        public global::KRPC.Client.Services.MechJeb.OperationLan OperationLan {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationLan", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationLan)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationLan), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationLongitude")]
        public global::KRPC.Client.Services.MechJeb.OperationLongitude OperationLongitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationLongitude", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationLongitude)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationLongitude), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationMoonReturn")]
        public global::KRPC.Client.Services.MechJeb.OperationMoonReturn OperationMoonReturn {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationMoonReturn", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationMoonReturn)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationMoonReturn), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationPeriapsis")]
        public global::KRPC.Client.Services.MechJeb.OperationPeriapsis OperationPeriapsis {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationPeriapsis", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationPeriapsis)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationPeriapsis), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationPlane")]
        public global::KRPC.Client.Services.MechJeb.OperationPlane OperationPlane {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationPlane", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationPlane)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationPlane), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationResonantOrbit")]
        public global::KRPC.Client.Services.MechJeb.OperationResonantOrbit OperationResonantOrbit {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationResonantOrbit", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationResonantOrbit)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationResonantOrbit), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationSemiMajor")]
        public global::KRPC.Client.Services.MechJeb.OperationSemiMajor OperationSemiMajor {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationSemiMajor", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationSemiMajor)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationSemiMajor), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ManeuverPlanner_get_OperationTransfer")]
        public global::KRPC.Client.Services.MechJeb.OperationTransfer OperationTransfer {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ManeuverPlanner))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ManeuverPlanner_get_OperationTransfer", _args);
                return (global::KRPC.Client.Services.MechJeb.OperationTransfer)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.OperationTransfer), connection);
            }
        }
    }

    public class NodeExecutor : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public NodeExecutor (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "NodeExecutor_Abort")]
        public void Abort ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor))
            };
            connection.Invoke ("MechJeb", "NodeExecutor_Abort", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "NodeExecutor_ExecuteAllNodes")]
        public void ExecuteAllNodes ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor))
            };
            connection.Invoke ("MechJeb", "NodeExecutor_ExecuteAllNodes", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "NodeExecutor_ExecuteOneNode")]
        public void ExecuteOneNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor))
            };
            connection.Invoke ("MechJeb", "NodeExecutor_ExecuteOneNode", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "NodeExecutor_get_Autowarp")]
        public bool Autowarp {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor))
                };
                ByteString _data = connection.Invoke ("MechJeb", "NodeExecutor_get_Autowarp", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "NodeExecutor_set_Autowarp", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "NodeExecutor_get_Enabled")]
        public bool Enabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor))
                };
                ByteString _data = connection.Invoke ("MechJeb", "NodeExecutor_get_Enabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "NodeExecutor_get_LeadTime")]
        public double LeadTime {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor))
                };
                ByteString _data = connection.Invoke ("MechJeb", "NodeExecutor_get_LeadTime", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "NodeExecutor_set_LeadTime", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "NodeExecutor_get_Tolerance")]
        public double Tolerance {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor))
                };
                ByteString _data = connection.Invoke ("MechJeb", "NodeExecutor_get_Tolerance", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.NodeExecutor)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "NodeExecutor_set_Tolerance", _args);
            }
        }
    }

    public class OperationApoapsis : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationApoapsis (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationApoapsis_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationApoapsis))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationApoapsis_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationApoapsis_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationApoapsis))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationApoapsis_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationApoapsis_get_NewApoapsis")]
        public double NewApoapsis {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationApoapsis))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationApoapsis_get_NewApoapsis", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationApoapsis)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationApoapsis_set_NewApoapsis", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationApoapsis_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationApoapsis))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationApoapsis_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    public class OperationCircularize : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationCircularize (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationCircularize_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationCircularize))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationCircularize_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationCircularize_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationCircularize))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationCircularize_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationCircularize_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationCircularize))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationCircularize_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    public class OperationCourseCorrection : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationCourseCorrection (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationCourseCorrection_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationCourseCorrection))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationCourseCorrection_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationCourseCorrection_get_CourseCorrectFinalPeA")]
        public double CourseCorrectFinalPeA {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationCourseCorrection))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationCourseCorrection_get_CourseCorrectFinalPeA", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationCourseCorrection)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationCourseCorrection_set_CourseCorrectFinalPeA", _args);
            }
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationCourseCorrection_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationCourseCorrection))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationCourseCorrection_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationCourseCorrection_get_InterceptDistance")]
        public double InterceptDistance {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationCourseCorrection))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationCourseCorrection_get_InterceptDistance", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationCourseCorrection)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationCourseCorrection_set_InterceptDistance", _args);
            }
        }
    }

    public class OperationEllipticize : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationEllipticize (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationEllipticize_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationEllipticize))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationEllipticize_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationEllipticize_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationEllipticize))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationEllipticize_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationEllipticize_get_NewApoapsis")]
        public double NewApoapsis {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationEllipticize))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationEllipticize_get_NewApoapsis", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationEllipticize)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationEllipticize_set_NewApoapsis", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationEllipticize_get_NewPeriapsis")]
        public double NewPeriapsis {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationEllipticize))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationEllipticize_get_NewPeriapsis", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationEllipticize)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationEllipticize_set_NewPeriapsis", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationEllipticize_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationEllipticize))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationEllipticize_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    public class OperationInclination : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationInclination (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationInclination_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationInclination))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationInclination_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationInclination_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationInclination))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationInclination_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationInclination_get_NewInclination")]
        public double NewInclination {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationInclination))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationInclination_get_NewInclination", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationInclination)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationInclination_set_NewInclination", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationInclination_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationInclination))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationInclination_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    public class OperationInterplanetaryTransfer : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationInterplanetaryTransfer (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationInterplanetaryTransfer_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationInterplanetaryTransfer))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationInterplanetaryTransfer_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationInterplanetaryTransfer_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationInterplanetaryTransfer))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationInterplanetaryTransfer_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationInterplanetaryTransfer_get_WaitForPhaseAngle")]
        public bool WaitForPhaseAngle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationInterplanetaryTransfer))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationInterplanetaryTransfer_get_WaitForPhaseAngle", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationInterplanetaryTransfer)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "OperationInterplanetaryTransfer_set_WaitForPhaseAngle", _args);
            }
        }
    }

    public class OperationKillRelVel : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationKillRelVel (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationKillRelVel_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationKillRelVel))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationKillRelVel_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationKillRelVel_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationKillRelVel))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationKillRelVel_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationKillRelVel_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationKillRelVel))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationKillRelVel_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    public class OperationLambert : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationLambert (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLambert_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLambert))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationLambert_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLambert_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLambert))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationLambert_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLambert_get_InterceptInterval")]
        public double InterceptInterval {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLambert))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationLambert_get_InterceptInterval", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLambert)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationLambert_set_InterceptInterval", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLambert_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLambert))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationLambert_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    /// <summary>Change longitude of ascending node</summary>
    public class OperationLan : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationLan (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLan_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLan))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationLan_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLan_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLan))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationLan_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLan_get_NewLAN")]
        public double NewLAN {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLan))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationLan_get_NewLAN", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLan)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationLan_set_NewLAN", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLan_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLan))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationLan_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    /// <summary>Change longitude of ascending node</summary>
    public class OperationLongitude : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationLongitude (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLongitude_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLongitude))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationLongitude_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLongitude_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLongitude))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationLongitude_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLongitude_get_NewSurfaceLongitude")]
        public double NewSurfaceLongitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLongitude))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationLongitude_get_NewSurfaceLongitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLongitude)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationLongitude_set_NewSurfaceLongitude", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationLongitude_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationLongitude))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationLongitude_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    public class OperationMoonReturn : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationMoonReturn (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationMoonReturn_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationMoonReturn))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationMoonReturn_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationMoonReturn_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationMoonReturn))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationMoonReturn_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationMoonReturn_get_MoonReturnAltitude")]
        public double MoonReturnAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationMoonReturn))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationMoonReturn_get_MoonReturnAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationMoonReturn)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationMoonReturn_set_MoonReturnAltitude", _args);
            }
        }
    }

    public class OperationPeriapsis : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationPeriapsis (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationPeriapsis_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationPeriapsis))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationPeriapsis_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationPeriapsis_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationPeriapsis))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationPeriapsis_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationPeriapsis_get_NewPeriapsis")]
        public double NewPeriapsis {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationPeriapsis))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationPeriapsis_get_NewPeriapsis", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationPeriapsis)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationPeriapsis_set_NewPeriapsis", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationPeriapsis_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationPeriapsis))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationPeriapsis_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    public class OperationPlane : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationPlane (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationPlane_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationPlane))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationPlane_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationPlane_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationPlane))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationPlane_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationPlane_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationPlane))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationPlane_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    public class OperationResonantOrbit : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationResonantOrbit (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationResonantOrbit_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationResonantOrbit))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationResonantOrbit_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationResonantOrbit_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationResonantOrbit))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationResonantOrbit_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationResonantOrbit_get_ResonanceDenominator")]
        public int ResonanceDenominator {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationResonantOrbit))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationResonantOrbit_get_ResonanceDenominator", _args);
                return (int)global::KRPC.Client.Encoder.Decode (_data, typeof(int), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationResonantOrbit)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(int))
                };
                connection.Invoke ("MechJeb", "OperationResonantOrbit_set_ResonanceDenominator", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationResonantOrbit_get_ResonanceNumerator")]
        public int ResonanceNumerator {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationResonantOrbit))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationResonantOrbit_get_ResonanceNumerator", _args);
                return (int)global::KRPC.Client.Encoder.Decode (_data, typeof(int), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationResonantOrbit)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(int))
                };
                connection.Invoke ("MechJeb", "OperationResonantOrbit_set_ResonanceNumerator", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationResonantOrbit_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationResonantOrbit))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationResonantOrbit_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    public class OperationSemiMajor : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationSemiMajor (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationSemiMajor_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationSemiMajor))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationSemiMajor_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationSemiMajor_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationSemiMajor))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationSemiMajor_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationSemiMajor_get_NewSemiMajorAxis")]
        public double NewSemiMajorAxis {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationSemiMajor))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationSemiMajor_get_NewSemiMajorAxis", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationSemiMajor)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "OperationSemiMajor_set_NewSemiMajorAxis", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationSemiMajor_get_TimeSelector")]
        public global::KRPC.Client.Services.MechJeb.TimeSelector TimeSelector {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationSemiMajor))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationSemiMajor_get_TimeSelector", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeSelector)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeSelector), connection);
            }
        }
    }

    /// <summary>Hohmann transfer to target</summary>
    public class OperationTransfer : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public OperationTransfer (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Create a new maneuver node.
        /// A warning may be stored in ErrorMessage during this process; so it may be useful to check its value.
        ///
        /// OperationException is thrown when there is something wrong with the operation.
        /// MJServiceException - Internal service error.
        /// </summary>
        /// <returns></returns>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationTransfer_MakeNode")]
        public global::KRPC.Client.Services.SpaceCenter.Node MakeNode ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationTransfer))
            };
            ByteString _data = connection.Invoke ("MechJeb", "OperationTransfer_MakeNode", _args);
            return (global::KRPC.Client.Services.SpaceCenter.Node)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Node), connection);
        }

        /// <summary>
        /// A warning may be stored there during MakeNode() call.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "OperationTransfer_get_ErrorMessage")]
        public string ErrorMessage {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.OperationTransfer))
                };
                ByteString _data = connection.Invoke ("MechJeb", "OperationTransfer_get_ErrorMessage", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }
    }

    public class RCSController : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public RCSController (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "RCSController_get_RCSForRotation")]
        public bool RCSForRotation {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RCSController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "RCSController_get_RCSForRotation", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RCSController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "RCSController_set_RCSForRotation", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "RCSController_get_RCSThrottle")]
        public bool RCSThrottle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RCSController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "RCSController_get_RCSThrottle", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RCSController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "RCSController_set_RCSThrottle", _args);
            }
        }
    }

    public class RendezvousAutopilot : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public RendezvousAutopilot (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "RendezvousAutopilot_get_DesiredDistance")]
        public double DesiredDistance {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RendezvousAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "RendezvousAutopilot_get_DesiredDistance", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RendezvousAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "RendezvousAutopilot_set_DesiredDistance", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "RendezvousAutopilot_get_Enabled")]
        public bool Enabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RendezvousAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "RendezvousAutopilot_get_Enabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RendezvousAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "RendezvousAutopilot_set_Enabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "RendezvousAutopilot_get_MaxPhasingOrbits")]
        public double MaxPhasingOrbits {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RendezvousAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "RendezvousAutopilot_get_MaxPhasingOrbits", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RendezvousAutopilot)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "RendezvousAutopilot_set_MaxPhasingOrbits", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "RendezvousAutopilot_get_Status")]
        public string Status {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.RendezvousAutopilot))
                };
                ByteString _data = connection.Invoke ("MechJeb", "RendezvousAutopilot_get_Status", _args);
                return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
            }
        }
    }

    public class SmartRCS : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public SmartRCS (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "SmartRCS_get_AutoDisableSmartRCS")]
        public bool AutoDisableSmartRCS {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.SmartRCS))
                };
                ByteString _data = connection.Invoke ("MechJeb", "SmartRCS_get_AutoDisableSmartRCS", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.SmartRCS)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "SmartRCS_set_AutoDisableSmartRCS", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "SmartRCS_get_Mode")]
        public global::KRPC.Client.Services.MechJeb.SmartRCSMode Mode {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.SmartRCS))
                };
                ByteString _data = connection.Invoke ("MechJeb", "SmartRCS_get_Mode", _args);
                return (global::KRPC.Client.Services.MechJeb.SmartRCSMode)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.SmartRCSMode), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.SmartRCS)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(global::KRPC.Client.Services.MechJeb.SmartRCSMode))
                };
                connection.Invoke ("MechJeb", "SmartRCS_set_Mode", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "SmartRCS_get_RCSController")]
        public global::KRPC.Client.Services.MechJeb.RCSController RCSController {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.SmartRCS))
                };
                ByteString _data = connection.Invoke ("MechJeb", "SmartRCS_get_RCSController", _args);
                return (global::KRPC.Client.Services.MechJeb.RCSController)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.RCSController), connection);
            }
        }
    }

    public class StagingController : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public StagingController (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// Stop at the selected stage.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "StagingController_get_AutostageLimit")]
        public int AutostageLimit {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "StagingController_get_AutostageLimit", _args);
                return (int)global::KRPC.Client.Encoder.Decode (_data, typeof(int), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(int))
                };
                connection.Invoke ("MechJeb", "StagingController_set_AutostageLimit", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "StagingController_get_AutostagePostDelay")]
        public double AutostagePostDelay {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "StagingController_get_AutostagePostDelay", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "StagingController_set_AutostagePostDelay", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "StagingController_get_AutostagePreDelay")]
        public double AutostagePreDelay {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "StagingController_get_AutostagePreDelay", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "StagingController_set_AutostagePreDelay", _args);
            }
        }

        /// <summary>
        /// The autostaging mode. If set to true, it will automatically disable itself after one staging action.
        /// </summary>
        /// <remarks>The controller needs to be enabled for this to work.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "StagingController_get_AutostagingOnce")]
        public bool AutostagingOnce {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "StagingController_get_AutostagingOnce", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "StagingController_set_AutostagingOnce", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "StagingController_get_ClampAutoStageThrustPct")]
        public double ClampAutoStageThrustPct {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "StagingController_get_ClampAutoStageThrustPct", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "StagingController_set_ClampAutoStageThrustPct", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "StagingController_get_Enabled")]
        public bool Enabled {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "StagingController_get_Enabled", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "StagingController_set_Enabled", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "StagingController_get_FairingMaxAerothermalFlux")]
        public double FairingMaxAerothermalFlux {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "StagingController_get_FairingMaxAerothermalFlux", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "StagingController_set_FairingMaxAerothermalFlux", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "StagingController_get_FairingMaxDynamicPressure")]
        public double FairingMaxDynamicPressure {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "StagingController_get_FairingMaxDynamicPressure", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "StagingController_set_FairingMaxDynamicPressure", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "StagingController_get_FairingMinAltitude")]
        public double FairingMinAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "StagingController_get_FairingMinAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.StagingController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "StagingController_set_FairingMinAltitude", _args);
            }
        }
    }

    public class TargetController : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public TargetController (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_GetPositionTargetPosition")]
        public systemAlias::Tuple<double,double,double> GetPositionTargetPosition ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
            };
            ByteString _data = connection.Invoke ("MechJeb", "TargetController_GetPositionTargetPosition", _args);
            return (systemAlias::Tuple<double,double,double>)global::KRPC.Client.Encoder.Decode (_data, typeof(systemAlias::Tuple<double,double,double>), connection);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_GetPositionTargetString")]
        public string GetPositionTargetString ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
            };
            ByteString _data = connection.Invoke ("MechJeb", "TargetController_GetPositionTargetString", _args);
            return (string)global::KRPC.Client.Encoder.Decode (_data, typeof(string), connection);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_PickPositionTargetOnMap")]
        public void PickPositionTargetOnMap ()
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
            };
            connection.Invoke ("MechJeb", "TargetController_PickPositionTargetOnMap", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_SetDirectionTarget")]
        public void SetDirectionTarget (string name)
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController)),
                global::KRPC.Client.Encoder.Encode (name, typeof(string))
            };
            connection.Invoke ("MechJeb", "TargetController_SetDirectionTarget", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_SetPositionTarget")]
        public void SetPositionTarget (global::KRPC.Client.Services.SpaceCenter.CelestialBody body, double latitude, double longitude)
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController)),
                global::KRPC.Client.Encoder.Encode (body, typeof(global::KRPC.Client.Services.SpaceCenter.CelestialBody)),
                global::KRPC.Client.Encoder.Encode (latitude, typeof(double)),
                global::KRPC.Client.Encoder.Encode (longitude, typeof(double))
            };
            connection.Invoke ("MechJeb", "TargetController_SetPositionTarget", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_UpdateDirectionTarget")]
        public void UpdateDirectionTarget (systemAlias::Tuple<double,double,double> direction)
        {
            var _args = new ByteString[] {
                global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController)),
                global::KRPC.Client.Encoder.Encode (direction, typeof(systemAlias::Tuple<double,double,double>))
            };
            connection.Invoke ("MechJeb", "TargetController_UpdateDirectionTarget", _args);
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_get_CanAlign")]
        public bool CanAlign {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TargetController_get_CanAlign", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_get_Distance")]
        public float Distance {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TargetController_get_Distance", _args);
                return (float)global::KRPC.Client.Encoder.Decode (_data, typeof(float), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_get_DockingAxis")]
        public systemAlias::Tuple<double,double,double> DockingAxis {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TargetController_get_DockingAxis", _args);
                return (systemAlias::Tuple<double,double,double>)global::KRPC.Client.Encoder.Decode (_data, typeof(systemAlias::Tuple<double,double,double>), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_get_NormalTargetExists")]
        public bool NormalTargetExists {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TargetController_get_NormalTargetExists", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_get_Position")]
        public systemAlias::Tuple<double,double,double> Position {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TargetController_get_Position", _args);
                return (systemAlias::Tuple<double,double,double>)global::KRPC.Client.Encoder.Decode (_data, typeof(systemAlias::Tuple<double,double,double>), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_get_PositionTargetExists")]
        public bool PositionTargetExists {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TargetController_get_PositionTargetExists", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_get_RelativePosition")]
        public systemAlias::Tuple<double,double,double> RelativePosition {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TargetController_get_RelativePosition", _args);
                return (systemAlias::Tuple<double,double,double>)global::KRPC.Client.Encoder.Decode (_data, typeof(systemAlias::Tuple<double,double,double>), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_get_RelativeVelocity")]
        public systemAlias::Tuple<double,double,double> RelativeVelocity {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TargetController_get_RelativeVelocity", _args);
                return (systemAlias::Tuple<double,double,double>)global::KRPC.Client.Encoder.Decode (_data, typeof(systemAlias::Tuple<double,double,double>), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TargetController_get_TargetOrbit")]
        public global::KRPC.Client.Services.SpaceCenter.Orbit TargetOrbit {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TargetController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TargetController_get_TargetOrbit", _args);
                return (global::KRPC.Client.Services.SpaceCenter.Orbit)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.SpaceCenter.Orbit), connection);
            }
        }
    }

    public class ThrustController : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public ThrustController (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_DifferentialThrottle")]
        public bool DifferentialThrottle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_DifferentialThrottle", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_DifferentialThrottle", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_DifferentialThrottleStatus")]
        public global::KRPC.Client.Services.MechJeb.DifferentialThrottleStatus DifferentialThrottleStatus {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_DifferentialThrottleStatus", _args);
                return (global::KRPC.Client.Services.MechJeb.DifferentialThrottleStatus)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.DifferentialThrottleStatus), connection);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_ElectricThrottle")]
        public bool ElectricThrottle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_ElectricThrottle", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_ElectricThrottle", _args);
            }
        }

        /// <remarks><see cref="M:MechJeb.ThrustController.ElectricThrottle" /> needs to be enabled.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_ElectricThrottleHi")]
        public double ElectricThrottleHi {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_ElectricThrottleHi", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_ElectricThrottleHi", _args);
            }
        }

        /// <remarks><see cref="M:MechJeb.ThrustController.ElectricThrottle" /> needs to be enabled.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_ElectricThrottleLo")]
        public double ElectricThrottleLo {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_ElectricThrottleLo", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_ElectricThrottleLo", _args);
            }
        }

        /// <summary>
        /// The jet safety margin. A value between 0 and 1.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_FlameoutSafetyPct")]
        public double FlameoutSafetyPct {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_FlameoutSafetyPct", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_FlameoutSafetyPct", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_LimitAcceleration")]
        public bool LimitAcceleration {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_LimitAcceleration", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_LimitAcceleration", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_LimitDynamicPressure")]
        public bool LimitDynamicPressure {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_LimitDynamicPressure", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_LimitDynamicPressure", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_LimitThrottle")]
        public bool LimitThrottle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_LimitThrottle", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_LimitThrottle", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_LimitToPreventFlameout")]
        public bool LimitToPreventFlameout {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_LimitToPreventFlameout", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_LimitToPreventFlameout", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_LimitToPreventOverheats")]
        public bool LimitToPreventOverheats {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_LimitToPreventOverheats", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_LimitToPreventOverheats", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_LimiterMinThrottle")]
        public bool LimiterMinThrottle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_LimiterMinThrottle", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_LimiterMinThrottle", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_ManageIntakes")]
        public bool ManageIntakes {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_ManageIntakes", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_ManageIntakes", _args);
            }
        }

        /// <summary>
        /// Limit acceleration to this value in m/s^2.
        /// </summary>
        /// <remarks><see cref="M:MechJeb.ThrustController.LimitAcceleration" /> needs to be enabled.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_MaxAcceleration")]
        public double MaxAcceleration {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_MaxAcceleration", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_MaxAcceleration", _args);
            }
        }

        /// <summary>
        /// Limit Q to this value in Pa.
        /// </summary>
        /// <remarks><see cref="M:MechJeb.ThrustController.LimitDynamicPressure" /> needs to be enabled.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_MaxDynamicPressure")]
        public double MaxDynamicPressure {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_MaxDynamicPressure", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_MaxDynamicPressure", _args);
            }
        }

        /// <summary>
        /// Limit throttle to this value between 0 and 1.
        /// </summary>
        /// <remarks><see cref="M:MechJeb.ThrustController.LimitThrottle" /> needs to be enabled.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_MaxThrottle")]
        public double MaxThrottle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_MaxThrottle", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_MaxThrottle", _args);
            }
        }

        /// <summary>
        /// Keep limited throttle over this value between 0 and 1.
        /// </summary>
        /// <remarks><see cref="M:MechJeb.ThrustController.LimiterMinThrottle" /> needs to be enabled.</remarks>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_MinThrottle")]
        public double MinThrottle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_MinThrottle", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_MinThrottle", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_SmoothThrottle")]
        public bool SmoothThrottle {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_SmoothThrottle", _args);
                return (bool)global::KRPC.Client.Encoder.Decode (_data, typeof(bool), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(bool))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_SmoothThrottle", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "ThrustController_get_ThrottleSmoothingTime")]
        public double ThrottleSmoothingTime {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController))
                };
                ByteString _data = connection.Invoke ("MechJeb", "ThrustController_get_ThrottleSmoothingTime", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.ThrustController)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "ThrustController_set_ThrottleSmoothingTime", _args);
            }
        }
    }

    public class TimeSelector : global::KRPC.Client.RemoteObject
    {
        /// <summary>
        /// Construct an instance of this remote object. Should not be called directly. This interface is intended for internal decoding.
        /// </summary>
        public TimeSelector (global::KRPC.Client.IConnection connection, UInt64 id) : base (connection, id)
        {
        }

        /// <summary>
        /// To be used with <see cref="M:MechJeb.TimeReference.Altitude" />.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TimeSelector_get_CircularizeAltitude")]
        public double CircularizeAltitude {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TimeSelector))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TimeSelector_get_CircularizeAltitude", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TimeSelector)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "TimeSelector_set_CircularizeAltitude", _args);
            }
        }

        /// <summary>
        /// To be used with <see cref="M:MechJeb.TimeReference.XFromNow" />.
        /// </summary>
        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TimeSelector_get_LeadTime")]
        public double LeadTime {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TimeSelector))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TimeSelector_get_LeadTime", _args);
                return (double)global::KRPC.Client.Encoder.Decode (_data, typeof(double), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TimeSelector)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(double))
                };
                connection.Invoke ("MechJeb", "TimeSelector_set_LeadTime", _args);
            }
        }

        [global::KRPC.Client.Attributes.RPCAttribute ("MechJeb", "TimeSelector_get_TimeReference")]
        public global::KRPC.Client.Services.MechJeb.TimeReference TimeReference {
            get {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TimeSelector))
                };
                ByteString _data = connection.Invoke ("MechJeb", "TimeSelector_get_TimeReference", _args);
                return (global::KRPC.Client.Services.MechJeb.TimeReference)global::KRPC.Client.Encoder.Decode (_data, typeof(global::KRPC.Client.Services.MechJeb.TimeReference), connection);
            }
            set {
                var _args = new ByteString[] {
                    global::KRPC.Client.Encoder.Encode (this, typeof(MechJeb.TimeSelector)),
                    global::KRPC.Client.Encoder.Encode (value, typeof(global::KRPC.Client.Services.MechJeb.TimeReference))
                };
                connection.Invoke ("MechJeb", "TimeSelector_set_TimeReference", _args);
            }
        }
    }
}
