# C# Automatic random noise image Generator.

### Usage example:
```
ContentGenerator.NoiseImageGenerator contentGenerator = new(1024);
// OR
ContentGenerator.NoiseImageGenerator contentGenerator = new(1024, noiseType, fractalType, frequency, octaves);

contentGenerator.Generate();
```

## Examples:
![1d79cc8d-2898-4d9d-a761-73b2f2d0b9ff](https://github.com/user-attachments/assets/e1f46456-62a9-44ac-8bca-53129beb6ddc)
![1024 OpenSimplex2S FBm 61f5c4c2-4d3f-4e04-8bb7-ac3b37a2a2ab](https://github.com/user-attachments/assets/38f2359e-1e59-4b2a-a448-7262e110b976)
![1024 OpenSimplex2S FBm 58a859d9-01a6-4147-aa4e-052b1d1269de](https://github.com/user-attachments/assets/431c6321-ec9f-4fbd-a792-a4f196fa5c9a)
![1024 OpenSimplex2 PingPong 08843f8e-7122-43dd-97ed-587d49e5a5c0](https://github.com/user-attachments/assets/fe061364-c3a7-4dde-968d-949cb4822c4a)
![1024 OpenSimplex2 PingPong 5811a1db-7cd3-4334-aa3d-4629d33b444f](https://github.com/user-attachments/assets/3ebdd34d-78e2-4355-a5c9-10cc06ef41d8)
![1024 OpenSimplex2 PingPong 823e8c70-bdca-405e-bcd5-cbe53dba04cd](https://github.com/user-attachments/assets/081f7eed-ac88-49ea-bbf6-8b5df7a96169)
![1024 OpenSimplex2 PingPong 6d17c95b-c3ce-4636-a258-3495f52807dd](https://github.com/user-attachments/assets/8505e755-09ef-470f-ac01-910af4c330b9)
![1024 OpenSimplex2 None ffd7c795-40ae-4254-9abe-14af812707a2](https://github.com/user-attachments/assets/8b5c2ab2-90c1-4c80-8bcf-99dcb106674e)
![1024 OpenSimplex2 DomainWarpProgressive 10de5674-b1eb-4f31-9e2f-17c5a8bdf74f](https://github.com/user-attachments/assets/a9e0afca-7816-45b9-8acb-eea880a8d8e5)
![1024 OpenSimplex2 DomainWarpProgressive 0d36cc07-98c1-4ef1-bc7a-1767ee353d9a](https://github.com/user-attachments/assets/a03c39c0-fb64-4b5e-a6c1-77ad3bf60507)
![1024 Cellular Ridged b3d45f74-c623-49d8-8cf7-d9402424b92f](https://github.com/user-attachments/assets/4a6085f2-790f-45f4-a35b-435f4dbdcb37)
![1024 Cellular Ridged af80369b-f1c8-4f4f-9daf-a75ad9181397](https://github.com/user-attachments/assets/4bdc2d7b-f11e-477d-b2ba-62ed0e5467cb)
![1024 Cellular PingPong 1ddca224-c402-4fed-9e61-88b8f9adbffe](https://github.com/user-attachments/assets/b4683249-8b3e-4970-b643-494f614d3796)
![164af745-7ee5-4651-a45f-d7d21431d312](https://github.com/user-attachments/assets/3a368cdc-3c75-4f07-9596-de2681414580)
![64e31cc6-3c90-4772-8382-2fa94785bff8](https://github.com/user-attachments/assets/9fa4488e-c73e-4f22-a17a-674fd9579b74)
![8c2c8fee-af49-4001-8d89-c67bbb3b963e](https://github.com/user-attachments/assets/c0828364-3842-4da8-ba4a-f473843ad1e5)
![7ef11169-803c-42ec-bd01-b36871db912e](https://github.com/user-attachments/assets/50e64a8f-598d-41a5-9725-e79dcd9a32a9)
![4dd646e8-fb0e-43fc-a4bc-9a8a43383fb2](https://github.com/user-attachments/assets/ee9f8edd-2a1c-472c-9151-ec01501ee175)
![1024 OpenSimplex2S None 2a911051-c080-4c50-9460-e1d5a6f3a67d](https://github.com/user-attachments/assets/8abe2a1b-8f26-459b-b4f3-76a485a966b3)
![1024 OpenSimplex2S FBm e364b099-766e-4f5a-9a4a-45155391dd5e](https://github.com/user-attachments/assets/e99bf717-92d9-41b7-b7eb-d6e78bb79034)
![1024 Perlin PingPong 42df9644-ad8f-4e2f-9f5a-670ac0843e9b](https://github.com/user-attachments/assets/61164110-6851-459a-9589-4297ee208067)
![1024 Perlin PingPong 6d6ecae8-ca88-4e6a-a82e-bf18f33b52dd](https://github.com/user-attachments/assets/20d5eec9-cdea-44a4-a3a3-3bed07034cf5)
![1024 Perlin None fbc2d354-f654-44c1-89ea-06a6ccd29d6e](https://github.com/user-attachments/assets/686dadb8-ea7b-48f1-87d8-43f3fa514cea)
![1024 Perlin DomainWarpProgressive 57390f30-dcc1-4b86-a779-6c9c5afdd577](https://github.com/user-attachments/assets/06ea8a79-cf83-4942-914b-75fcfcb28e65)
![1024 Perlin DomainWarpProgressive 068c5a82-91ec-4ea2-a045-8ce2271484e2](https://github.com/user-attachments/assets/8955c801-39b2-4269-adbe-1512e9f523d6)
![1024 Perlin DomainWarpProgressive 00b5a211-0053-4b96-922d-37ccd0e21332](https://github.com/user-attachments/assets/e903d7af-4e4f-4555-9eab-00565ba6c057)
![eba326b5-f283-492f-829d-0d37032f2a14](https://github.com/user-attachments/assets/cb8071f4-7ced-45f7-a511-ba8024273b9a)
![c748eea8-4beb-44a3-b972-bc7dc3f0a1a5](https://github.com/user-attachments/assets/3928da2e-3faf-4c0b-83cd-da8bb510834e)
![09241245-52a1-4611-96e0-e48c0e39224d](https://github.com/user-attachments/assets/ffe1ac6c-59e3-4b3c-b9e0-d437025b51b7)
![1024 Value PingPong 10279e6a-b27b-43d2-9898-3156c04090be](https://github.com/user-attachments/assets/160f5f2e-d223-4178-abe1-59c1c46f98e7)
![1024 Value PingPong 323dfe00-8619-4947-9f2a-56a2d4235dbf](https://github.com/user-attachments/assets/fbe1ebdd-cd94-457c-b62d-bb6b16af7ba7)
![1024 Value PingPong 82f1fe79-a79d-440f-b692-e03a992eaf10](https://github.com/user-attachments/assets/5e613628-fa45-4fa2-841f-e1f80ff0d9c0)
![1024 Value PingPong 10f748e2-6f29-46e2-92a6-32191578ad8d](https://github.com/user-attachments/assets/7a75695d-f051-486b-b14b-74dc220ddee3)
![1024 ValueCubic None 8ff386c6-cfb3-44bb-976e-2aa46bf15385](https://github.com/user-attachments/assets/05d29e18-f8c6-4c63-843f-9b9a26f33823)
![1024 ValueCubic None 6e99a7ed-5527-4056-8fb5-12f289640d86](https://github.com/user-attachments/assets/0a719fbf-3009-4c60-acc6-fb28bec49a26)
![1024 ValueCubic None 1bbc9dd4-5dc2-49e5-b87f-a8f6a81b2236](https://github.com/user-attachments/assets/ee8d4a86-e09c-4332-8678-f63a25843e11)
![1024 ValueCubic FBm bedaf058-89d7-4c40-9b2a-52d128ab6e24](https://github.com/user-attachments/assets/b6c9f225-33aa-42be-a057-82ba5dfab4a5)
![1024 ValueCubic FBm 74dc40e7-7b56-42f0-8ec8-dd3f2f1ca2b1](https://github.com/user-attachments/assets/3cda1c45-10db-48ef-a022-f56c53f181d6)
![1024 ValueCubic FBm 41b10ca2-2247-472c-bb2d-9022f1737230](https://github.com/user-attachments/assets/59859116-76f4-42bd-8632-28f826e23e34)
![1024 OpenSimplex2S Ridged 7ed2a8e8-b2ef-4bd1-96bf-61d262832127](https://github.com/user-attachments/assets/d0ed1434-aafe-48ba-86e6-e9b8e63509b8)
![1024 Perlin PingPong 1770a63a-b461-442e-94e6-7c21d85cd94e](https://github.com/user-attachments/assets/8022d6f1-da96-40e0-81f1-97733cb0c895)
![003477e2-3fe5-4a27-8584-693a7c6bee6a](https://github.com/user-attachments/assets/6a256fa0-bea1-4498-ae25-2523200d2911)
