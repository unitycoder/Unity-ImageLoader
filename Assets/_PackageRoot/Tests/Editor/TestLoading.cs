using UnityEngine.TestTools;
using System.Collections;

namespace Extensions.Unity.ImageLoader.Tests
{
    public partial class TestLoading : Test
    {
        [UnitySetUp] public override IEnumerator SetUp() => base.SetUp();
        [UnityTearDown] public override IEnumerator TearDown() => base.TearDown();
    }
}