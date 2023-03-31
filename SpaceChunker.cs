using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChunkI{
    public enum Type{ None, ChunkHolder, ChunkEndPoint};
    public virtual Type type{ get{return Type.None;}}

}
public class ChunkEndPoint : ChunkI{
    public override Type type{ get{ return ChunkI.Type.ChunkEndPoint;}}
    List<ObjI> objInside = new List<ObjI>();
}
public class ChunkHolder : ChunkI{
    public override Type type{ get{ return ChunkI.Type.ChunkHolder;}}
    
    public class LineZ{
        List<ChunkI> lineZ = new List<ChunkI>();

        public ChunkI getChunkI( int z, ChunkEndPoint.Type type){
            var aux = lineZ[ z];
            if( aux == null){
                switch( type){
                    case ChunkEndPoint.Type.ChunkEndPoint:
                        aux = new ChunkEndPoint();  
                    break;
                    case ChunkEndPoint.Type.ChunkHolder:
                        aux = new ChunkHolder();
                    break;
                }
                lineZ[ z] = aux;
            }

            return aux;
        }
    }
    public class LineY{
        public List<LineZ> lineY = new List<LineZ>();
        public LineZ getLineZ( int y){
            var aux = lineY[y];
            if( aux == null){
                aux = new LineZ();
                lineY[y] = aux;
            }
            return aux;
        }
    }
    public class LineX{
        public List<LineY> lineX = new List<LineY>();
        public LineY getLineY( int x){
            var aux = lineX[x];
            if( aux == null){
                aux = new LineY();
                lineX[x] = aux;
            }
            return aux;
        }
    }

    LineX lineX;

    LineX getLineX(){
        if( lineX == null){
            lineX = new LineX();
        }
        return lineX;
    }

    void addChunk( int x, int y, int z, ObjI obj){
        var lineX = getLineX();
        var lineY = lineX.getLineY( x);
        var lineZ = lineY.getLineZ( y);
        var endpoint = lineZ.getChunkI( z, )
    }
}

public class SpaceChunker : MonoBehaviour
{
    public static SpaceChunker Instance;

    void Awake(){
        if( Instance == null){
            Instance = this;
        }
    }
    
    float chunkSize = 1;

    ChunkHolder[] a = new ChunkHolder[4];

    void create

    void OnDrawGizmos(){
        //Gizmos.DrawCube()
    }
}
