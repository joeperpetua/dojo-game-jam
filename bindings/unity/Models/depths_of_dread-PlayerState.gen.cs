// Generated by dojo-bindgen on Wed, 30 Oct 2024 17:53:29 +0000. Do not modify this file manually.
using System;
using Dojo;
using Dojo.Starknet;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Enum = Dojo.Starknet.Enum;


namespace depths_of_dread {
    // Model definition for `depths_of_dread::models::PlayerState` model
    public class PlayerState : ModelInstance {
        [ModelField("player")]
        public FieldElement player;

        [ModelField("game_id")]
        public uint game_id;

        [ModelField("current_floor")]
        public ushort current_floor;

        [ModelField("position")]
        public Vec2 position;

        [ModelField("coins")]
        public ushort coins;

        // Start is called before the first frame update
        void Start() {
        }
    
        // Update is called once per frame
        void Update() {
        }
    }
}

        