// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace ProjectTemplate.Tests;

[TestClass]
public class ExampleProjectTemplateTestClass
{
    // TODO: https://github.com/CommunityToolkit/Labs-Windows/issues/160
    [TestMethod]
    public async Task SimpleExampleTest()
    {
        await CommunityToolkit.Labs.UnitTests.App.DispatcherQueue.EnqueueAsync(() =>
        {
//#if (!backed)
            var systemUnderTest = new ProjectTemplate_ClassicBinding();
//#else
            var systemUnderTest = new ProjectTemplate_xBind();
//#endif
            Assert.IsNotNull(systemUnderTest);
        });
    }
}
