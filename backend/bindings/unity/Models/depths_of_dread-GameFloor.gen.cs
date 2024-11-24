// Generated by dojo-bindgen on Sun, 24 Nov 2024 19:07:25 +0000. Do not modify this file manually.
using System;
using Dojo;
using Dojo.Starknet;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Enum = Dojo.Starknet.Enum;
using BigInteger = System.Numerics.BigInteger;

// Type definition for `depths_of_dread::models::Vec2` struct
[Serializable]
public struct Vec2 {
    public uint x;
    public uint y;
}

// Type definition for `depths_of_dread::models::Direction` enum
public abstract record Direction() : Enum {
    public record None() : Direction;
    public record Left() : Direction;
    public record Right() : Direction;
    public record Up() : Direction;
    public record Down() : Direction;
}


// Model definition for `depths_of_dread::models::GameFloor` model
public class depths_of_dread_GameFloor : ModelInstance {
    [ModelField("game_id")]
        public uint game_id;

        [ModelField("size")]
        public Vec2 size;

        [ModelField("path")]
        public Direction[] path;

        [ModelField("end_tile")]
        public Vec2 end_tile;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }
}

        