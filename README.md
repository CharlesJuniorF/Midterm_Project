#### MCS 1643 README file
# MCS-1643 Midterm Project

#### Author: *CJ Feller*

##### Modified: *2025-10-30*

<br>


#### Questions for projects: (remove this section for tutorial assignments)
**1. What are the controls to your game? How do we play?**   

*You control the game by using the right and left arrow keys or A and D keys on the keyboard. You can jump by pressing W or space bar. Whenever you have the arrowPower power up you can press x to shoot an arrow at enimeies that peirces through 3 before stopping.*
> &nbsp;
><i>(art, music, etc. Just tell us where you got it, link it here)</i>   
> &nbsp;
 


**2. What creative additions/enhancements did you make? How can we find them?**   


*The one absolute addition I made to the game was the arrow power. Everything else is pretty standard for what Super Mario Bros. really is. You can find the arrow power by jumping into the second mystery block inside the game. After that you should be able to attack enemies. Careful though, you could lose it if you're not careful.*
> &nbsp;
><i>(If you don't tell us how to experience them, we could easily miss them.)</i>   
> &nbsp;
 


**3. Any assets used that you didn't create yourself?**   

*The sprite assets I used are from 3 sites really. The first site was for the arrow sprite. The second site was for the font type. The third and final site was where I downloaded all the mario sprites. The sprites are from a github repo linked from a video tutorial I followed to create this project.*
1. arrow sprite: https://www.newgrounds.com/art/view/blankcanvasstudios/arrow-pixel-art

2. fonts: https://www.fontspace.com/category/8-bit

3. path to get to sprites is assets/sprites: https://github.com/zigurous/unity-super-mario-tutorial.git

> &nbsp;
><i>(art, music, etc. Just tell us where you got it, link it here)</i>   
> &nbsp;
 


**4. Did you receive help from anyone outside this class or from anyone in this class that is not in a group with you?**   

*No. However I did follow a video tutorial for the code of SMB.*

> &nbsp;
><i>(list their names and what they helped with)</i>   
> &nbsp;
 


**5. Did you get help from any AI Code Assistants?**   

*No. The tutorial I followed was extremely comprehensive. Unless you consider the code assisstant inside the Visual Studio part of that I more rather was fighting it than letting it help me. It was so annoying having that thing autofill the code. Esc is my best friend :)*

> &nbsp;
><i>(Including things like Chat-GPT, Copilot, etc. Tell us which .cs file to look in for the citation and describe what you learned)</i>   
> &nbsp;
 


**6. Did you get help from any online websites, videos, or tutorials?**   

*Yes. As I was getting deeper into the project I felt as though I was getting in way over my head. Unfortunately I did have to turn to a video tutorial to learn how to go about most of the mechanics in the game. However, I will say that the tutorial taught me some very important information about how unity works internally and that I really should break down every specific detail to its barebones. I should never overlycomplicate something otherwise it may come out sloppy, disfunctional, or leave me quite overwelhmed leaving me with questions like "Oh god where do I start." I also reference the Unity Manual to grasp a better understanding of certain functions like raycasting, spriteRenderer, and onBecameInvisible for example.*

The person I followed for this information is a man by the name Adam who runs the YouTube channel Zigurous. He mainly helped guide me through the coding aspect of this game. Everything else fell to me in terms of design and creation. Here is the tutorial: https://www.youtube.com/playlist?list=PLqlFiJjSZ2x1mrMpSQgYdRm8PyWRTg6He

> &nbsp;
><i>(link them here)</i>   
> &nbsp;
 


**7. What trouble did you have with this project?**   

*I say my biggest problem was being to broad in my approach to this project. I would try to tackle one big problem, end up overthinking it, and try moving on to the next problem only to repeat the process. In the future I really need to give myself a better outline of how the code should look. Like rather than breaking down the player into "How do they move and how do they attack?" I should ask "How does the player move forward? How do they move backward? How do I make them jump? How do I make gravity effect them?" Even then I could problem break down the problems further.*

> &nbsp;
><i>(Even if you didn't complete the project, you can still get partial credit if you tell us about why it's incomplete.)</i>   
> &nbsp;
 


**8. Is there anything else we should know?**   

*I refuse to ever give up on my dream. Just because I want to chase becoming a game developer doesn't change the fact that I'm extremely new to the subject. While my coding background is minor I need to focus more on it to become a better developer overall. Be patient with me and watch me grow on my journey if you like a show.*

> &nbsp;
>*No answer given.*
> &nbsp;

---

# This starter is based on Jeremy Gibson Bond's MI 231 Starter, https://github.com/MSU-mi231/Unity-3D-Template-2022.3
# (which in turn incorporates some collaborative work and suggestions from me)

# Default GitLab README Content is Below
To make it easy for you to get started with GitLab, here's a list of recommended next steps.

Already a pro? Just edit this README.md and make it your own. Want to make it easy? [Use the template at the bottom](#editing-this-readme)!

## Add your files

- [ ] [Create](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#create-a-file) or [upload](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#upload-a-file) files
- [ ] [Add files using the command line](https://docs.gitlab.com/ee/gitlab-basics/add-file.html#add-a-file-using-the-command-line) or push an existing Git repository with the following command:

```
cd existing_repo
git remote add origin https://gitlab.msu.edu/mi231-f22/templates/unity-project-template.git
git branch -M main
git push -uf origin main
```

## Integrate with your tools

- [ ] [Set up project integrations](https://gitlab.msu.edu/mi231-f22/templates/unity-project-template/-/settings/integrations)

## Collaborate with your team

- [ ] [Invite team members and collaborators](https://docs.gitlab.com/ee/user/project/members/)
- [ ] [Create a new merge request](https://docs.gitlab.com/ee/user/project/merge_requests/creating_merge_requests.html)
- [ ] [Automatically close issues from merge requests](https://docs.gitlab.com/ee/user/project/issues/managing_issues.html#closing-issues-automatically)
- [ ] [Enable merge request approvals](https://docs.gitlab.com/ee/user/project/merge_requests/approvals/)
- [ ] [Automatically merge when pipeline succeeds](https://docs.gitlab.com/ee/user/project/merge_requests/merge_when_pipeline_succeeds.html)

## Test and Deploy

Use the built-in continuous integration in GitLab.

- [ ] [Get started with GitLab CI/CD](https://docs.gitlab.com/ee/ci/quick_start/index.html)
- [ ] [Analyze your code for known vulnerabilities with Static Application Security Testing(SAST)](https://docs.gitlab.com/ee/user/application_security/sast/)
- [ ] [Deploy to Kubernetes, Amazon EC2, or Amazon ECS using Auto Deploy](https://docs.gitlab.com/ee/topics/autodevops/requirements.html)
- [ ] [Use pull-based deployments for improved Kubernetes management](https://docs.gitlab.com/ee/user/clusters/agent/)
- [ ] [Set up protected environments](https://docs.gitlab.com/ee/ci/environments/protected_environments.html)

***

# Editing this README

When you're ready to make this README your own, just edit this file and use the handy template below (or feel free to structure it however you want - this is just a starting point!). Thank you to [makeareadme.com](https://www.makeareadme.com/) for this template.

## Suggestions for a good README
Every project is different, so consider which of these sections apply to yours. The sections used in the template are suggestions for most open source projects. Also keep in mind that while a README can be too long and detailed, too long is better than too short. If you think your README is too long, consider utilizing another form of documentation rather than cutting out information.

## Name
Choose a self-explaining name for your project.

## Description
Let people know what your project can do specifically. Provide context and add a link to any reference visitors might be unfamiliar with. A list of Features or a Background subsection can also be added here. If there are alternatives to your project, this is a good place to list differentiating factors.

## Badges
On some READMEs, you may see small images that convey metadata, such as whether or not all the tests are passing for the project. You can use Shields to add some to your README. Many services also have instructions for adding a badge.

## Visuals
Depending on what you are making, it can be a good idea to include screenshots or even a video (you'll frequently see GIFs rather than actual videos). Tools like ttygif can help, but check out Asciinema for a more sophisticated method.

## Installation
Within a particular ecosystem, there may be a common way of installing things, such as using Yarn, NuGet, or Homebrew. However, consider the possibility that whoever is reading your README is a novice and would like more guidance. Listing specific steps helps remove ambiguity and gets people to using your project as quickly as possible. If it only runs in a specific context like a particular programming language version or operating system or has dependencies that have to be installed manually, also add a Requirements subsection.

## Usage
Use examples liberally, and show the expected output if you can. It's helpful to have inline the smallest example of usage that you can demonstrate, while providing links to more sophisticated examples if they are too long to reasonably include in the README.

## Support
Tell people where they can go to for help. It can be any combination of an issue tracker, a chat room, an email address, etc.

## Roadmap
If you have ideas for releases in the future, it is a good idea to list them in the README.

## Contributing
State if you are open to contributions and what your requirements are for accepting them.

For people who want to make changes to your project, it's helpful to have some documentation on how to get started. Perhaps there is a script that they should run or some environment variables that they need to set. Make these steps explicit. These instructions could also be useful to your future self.

You can also document commands to lint the code or run tests. These steps help to ensure high code quality and reduce the likelihood that the changes inadvertently break something. Having instructions for running tests is especially helpful if it requires external setup, such as starting a Selenium server for testing in a browser.

## Authors and acknowledgment
Show your appreciation to those who have contributed to the project.

## License
For open source projects, say how it is licensed.

## Project status
If you have run out of energy or time for your project, put a note at the top of the README saying that development has slowed down or stopped completely. Someone may choose to fork your project or volunteer to step in as a maintainer or owner, allowing your project to keep going. You can also make an explicit request for maintainers.