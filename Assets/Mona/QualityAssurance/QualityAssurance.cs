#if UNITY_EDITOR
using System;
using UnityEngine;
using System.Collections.Generic;

namespace Mona
{
    // Quality Checks that run both in editor and in private-build
    public static partial class QualityAssurance
    {
        // Is a list of error codes generated by the space.
        public static Dictionary<string, List<int>> SpaceErrors;
        public static EditorHierarchyDrawer HierarchyDrawer;

        // Run QA check
        public static Dictionary<string, List<int>> GetSpaceErrors()
        {
            // Add a test error
            SpaceErrors = new Dictionary<string, List<int>>();

            TestSceneExistence("Space", MonaErrorCodes.MISSING_SPACE_SCENE);
            TestSceneExistence("Portals", MonaErrorCodes.MISSING_PORTAL_SCENE);
            TestSceneExistence("Artifacts", MonaErrorCodes.MISSING_ARTIFACT_SCENE);

            TestSceneLayer("Space", "Space", MonaErrorCodes.MISSING_SPACE_LAYER, MonaErrorCodes.MULTIPLE_SPACE_ROOTS);
            TestSceneLayer("Portals", "PortalLayer", MonaErrorCodes.MISSING_PORTAL_LAYER, MonaErrorCodes.MULTIPLE_PORTAL_ROOTS);
            TestSceneLayer("Artifacts", "ArtifactLayer", MonaErrorCodes.MISSING_ARTIFACT_LAYER, MonaErrorCodes.MULTIPLE_ARTIFACT_ROOTS);

            TestObjectPlacements("Artifact", "ArtifactLayer", MonaErrorCodes.BAD_ARTIFACT_PLACEMENT);
            TestObjectPlacements("Canvas", "ArtifactLayer", MonaErrorCodes.BAD_CANVAS_PLACEMENT);
            TestObjectPlacements("Portal", "PortalLayer", MonaErrorCodes.BAD_PORTAL_PLACEMENT);

            TestNameUniqueness("Artifact", MonaErrorCodes.DUPLICATE_ARTIFACT_NAME);
            TestNameUniqueness("Canvas", MonaErrorCodes.DUPLICATE_CANVAS_NAME);
            TestNameUniqueness("Portal", MonaErrorCodes.DUPLICATE_PORTAL_NAME);

            TestLayerContents("PortalLayer", "Portal", MonaErrorCodes.BAD_PORTAL_LAYER_CONTENTS);

            TestObjectColliders<MeshCollider>("Canvas", MonaErrorCodes.BAD_CANVAS_COLLIDER);
            TestObjectColliders<Collider>("Artifact", MonaErrorCodes.BAD_ARTIFACT_COLLIDER);
            TestObjectColliders<BoxCollider>("Portal", MonaErrorCodes.BAD_PORTAL_COLLIDER);

            TestCrunchCompression(MonaErrorCodes.TEXTURE_CRUNCH_COMPRESSION);

            if (HierarchyDrawer != null)
            {
                HierarchyDrawer.Unregister();
            }
            else
            {
                HierarchyDrawer = new EditorHierarchyDrawer();
            }

            HierarchyDrawer.Register(SpaceErrors);

            return SpaceErrors;
        }
    }
}
#endif