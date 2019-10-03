/*using System;
using System.IO;
using UnityEngine;
using CsvHelper;

namespace Vhil.DataCollector
{
    public static class Extensions
    {
        public static void Write(this DataWriter<TrackingData> trackingDataWriter, Rigidbody rb)
        {
            trackingDataWriter.Write(TrackingData.Create(rb));
        }
    }

    public class TrackingData
    {
        public float TimeStamp { get; private set; }
        public float PositionX { get; private set; }
        public float PositionY { get; private set; }
        public float PositionZ { get; private set; }
        public float RotationW { get; private set; }
        public float RotationX { get; private set; }
        public float RotationY { get; private set; }
        public float RotationZ { get; private set; }
        public float Velocity { get; private set; }
        public bool IsFlying { get; private set; }

        public TrackingData(float timeStamp, float positionX, float positionY, float positionZ,
                            float rotationW, float rotationX, float rotationY, float rotationZ, float velocity, bool isFlying)
        {
            TimeStamp = timeStamp;
            PositionX = positionX;
            PositionY = positionY;
            PositionZ = positionZ;
            RotationW = rotationW;
            RotationX = rotationX;
            RotationY = rotationY;
            RotationZ = rotationZ;
            Velocity = velocity;
            IsFlying = isFlying;

        }

        public static TrackingData Create(float time, Rigidbody rigidbody)
        {
            return new TrackingData(timeStamp: time,
                                    positionX: rigidbody.position.x,
                                    positionY: rigidbody.position.y,
                                    positionZ: rigidbody.position.z,
                                    rotationW: rigidbody.rotation.w,
                                    rotationX: rigidbody.rotation.x,
                                    rotationY: rigidbody.rotation.y,
                                    rotationZ: rigidbody.rotation.z,
                                    velocity: rigidbody.velocity.magnitude,
                                    isFlying: (rigidbody.velocity.magnitude > 0.5));
        }

        public static TrackingData Create(Rigidbody rigidbody)
        {
            return Create(Time.time, rigidbody);
        }
    }
    public class DataWriter<T> : IDisposable
    {
        private readonly CsvWriter writer;

        private DataWriter(CsvWriter writer)
        {
            this.writer = writer;
        }

        public static DataWriter<T> Create(string path)
        {
            var streamWriter = new StreamWriter(path);
            var csvWriter = new CsvHelper.CsvWriter(streamWriter);
            csvWriter.WriteHeader<T>();
            csvWriter.NextRecord();
            return new DataWriter<T>(csvWriter);
        }

        public void Write(T t)
        {
            writer.WriteRecord(t);
            writer.NextRecord();
        }

        public void Dispose()
        {
            writer.Dispose();
        }
    }
}
*/
