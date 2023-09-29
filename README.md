^^^^^^^^^
1. Create a new folder with the name position-api-server.
2. Navigate inside the folder from the command line and execute the following command
   npm init -y
   This will create a package.json file inside your project.
3. Install the json-server npm package by executing the following command
   npm install json-server
4. Create a new file with the name .gitignore with the entry for node_modules inside it so the node_modules folder will not be pushed to  
   GitHub while pushing the code to the GitHub repository.
5. Create a new file with the name db.json and add the following contents inside it:
   {
  "position": [
    {
      "x": 9,
      "y": 9,
      "z": 9
    }
  ]
}
6. Open package.json file and add the scripts section inside it:
"scripts": {
  "start": "json-server db.json"
}
7. Start the application by running the npm start command from the terminal.
8. Now access "http://localhost:3000/position"

********************


![github_v3](https://user-images.githubusercontent.com/16878403/213307671-f153951f-b0ce-4c19-96a3-321e8254bef7.png)
<p align="center">Start building your own custom Mona Space using our official template</p>

## ⬇️ Unity Version
This template requires the ```Unity 2022.3.6f1``` version. You can download it here:
https://unity.com/releases/editor/qa/lts-releases

Be sure to also install ```WebGL Build Support``` or you won't be able to export your space.


## 📃 Documentation

The official documentation website is [docs.monaverse.com](https://docs.monaverse.com/create/building-spaces/get-started).

Mona [Video tutorials here](https://docs.monaverse.com/create/resources/mona-tutorials)


## 💬 Support

For support, join our [Discord support channel](https://discord.gg/gcrGHzTerU)

## ⚙️ Template version
2.0.6

## 🔄 Updating Template

The in-editor [Template Utility](https://docs.monaverse.com/create/building-spaces/mona-tools/template-utility) will notify you of available updates for your project. Stay connected with our community in [Discord](https://discord.gg/gcrGHzTerU) to get detailed updates on what's included in each release!

![image](https://github.com/monaverse/SpaceStarter/assets/16878403/66debdad-def6-4af3-8f2b-815d89ea83c4)

## 🛠️ Mona Library

Also, be sure to check out the [Mona Library](https://docs.monaverse.com/create/resources/mona-library) for access to additional tools and pre-built assets from both our team and the wider community.

![image](https://github.com/monaverse/SpaceStarter/assets/16878403/d8069f0e-8f4c-42db-98c9-10dde00d8fc3)
# EncodeClub-OpenDataHack-Mona
