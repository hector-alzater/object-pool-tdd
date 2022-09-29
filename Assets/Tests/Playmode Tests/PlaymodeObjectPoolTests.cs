using System.Collections;
using IDED.Scripting.Pool;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlaymodeObjectPoolTests
{
    private ObjectPool _pool;
    
    [SetUp]
    public void InitializeObjectPool()
    {
        _pool = GameObject.Instantiate<ObjectPool>(Resources.Load<ObjectPool>("BulletPool"));
    }

    [UnityTest]
    public IEnumerator AllocatesAnInstance()
    {
        yield return new WaitForEndOfFrame();
        Assert.NotNull(_pool.Allocate().GetComponent<Rigidbody>());
        yield return null;
    }
    
    //TODO: 3 tests

    [TearDown]
    public void DestroyObjectPool()
    {
        GameObject.Destroy(_pool.gameObject);
    }
}
