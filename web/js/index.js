const help = document.querySelector(".help");



help.addEventListener('click',function(){
    let helpBox = document.createElement('div');
    helpBox.classList.add('help_box');
    let helpBoxTop = document.createElement('div');
    helpBoxTop.classList.add('help_box_top');
    let helpBoxBot = document.createElement('div');
    helpBoxBot.classList.add('help_box_bot');
    let helpBoxLogo = document.createElement('div');
    helpBoxLogo.classList.add('help_box_logo');
    let helpBoxImg = document.createElement('img');
    helpBoxImg.setAttribute('src', 'images/logo.png');
    let helpBoxHide = document.createElement('div');
    helpBoxHide.classList.add('help_box_hide');
    let helpBoxHideBtn = document.createElement('button');
    helpBoxHide.appendChild(helpBoxHideBtn);
    helpBoxLogo.appendChild(helpBoxImg);
    helpBoxTop.appendChild(helpBoxLogo);
    helpBoxTop.appendChild(helpBoxHide);

    let helpBoxBotHeader = document.createElement('div');
    helpBoxBotHeader.classList.add('help_box_bot_header');
    helpBoxBotHeader.innerHTML = "<br><p>Здравствуйте!</p><h2>На данный момент наблюдается высокая нагрузка на сайте. Специалисты могут отвечать с небольшой задержской.        </h2><br><h4>Простите, за доставленные неудобства</h4><button>Начать</button>"
    helpBoxBot.appendChild(helpBoxBotHeader)
    helpBox.appendChild(helpBoxTop);
    helpBox.appendChild(helpBoxBot);
    document.body.appendChild(helpBox);
helpBox.style.opacity=1;
    
    const hideBtn = document.querySelector(".help_box_hide");
    hideBtn.addEventListener('click',function(){
        helpBox.remove();
    })
    const btnStart = document.querySelector(".help_box_bot_header button");
    btnStart.addEventListener('click', function(){
        btnStart.style.display= "none";
        document.querySelector(".help_box_bot_header p").style.display="none";
        document.querySelector(".help_box_bot_header h2").style.display="none";
        document.querySelector(".help_box_bot_header h4").style.display="none";
        let chooseP = document.createElement('h2');
        chooseP.innerText = "Выберете, что именно вам нужно, чтобы мы смогли подобрать вам специалиста"
        let newCustomer = document.createElement('button');
        newCustomer.classList.add('help_box_newcust');
        newCustomer.innerText = "Мне нужна помощь в выборе при покупке";
        newCustomer.style.fontSize = "14px";
        newCustomer.style.width = "155px";
        newCustomer.style.left="10%";
        newCustomer.style.top="30%";

        let oldCustomer = document.createElement('button');
        oldCustomer.classList.add('help_box_oldcust');
        oldCustomer.innerText = "Мне нужна помощь с использованием СКК";
        oldCustomer.style.fontSize = "14px";
        oldCustomer.style.width = "155px";
        oldCustomer.style.left="50%";
        oldCustomer.style.top="45%";

        let troubles = document.createElement('button');
        troubles.classList.add('help_box_troubles');
        troubles.innerText = "У меня возникли проблемы при оплате товара";
        troubles.style.fontSize = "14px";
        troubles.style.width = "155px";
        troubles.style.left="10%";
        troubles.style.top="59%";

        let elseB = document.createElement('button');
        elseB.classList.add('help_box_else');
        elseB.innerText = "Другое";
        elseB.style.fontSize = "14px";
        elseB.style.width = "155px";
        elseB.style.left="50%";
        elseB.style.top="73%";

        chooseP.style.paddingTop="5px";
        chooseP.style.marginBottom="10px";
        helpBoxBotHeader.appendChild(chooseP);
        helpBoxBotHeader.appendChild(troubles);
        helpBoxBotHeader.appendChild(elseB);
        helpBoxBotHeader.appendChild(newCustomer);
        helpBoxBotHeader.appendChild(oldCustomer);
    });
})
