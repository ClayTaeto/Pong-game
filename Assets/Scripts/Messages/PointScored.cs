using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeControl;

public class PointScored : Message
{
    public string player;
    public PointScored(string player) {
        this.player = player;
    }
}
