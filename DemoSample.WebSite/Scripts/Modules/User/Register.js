var $ApiURL = 'http://localhost/demo_api/api/User';
var vue = new Vue({
    el: '#app', //網頁最外層的 id，所有 vue 操控的部分，皆要寫在裡面
    data: {
        user:
        {
            id: '',
            name: '',
            acct: ''
        }
        //網頁用到的資料都放在這
    },
    created: function () {
        // 網頁載入完成，先執行的 function 內容寫在這(像 jQ 的 .ready())
    },
    methods: {
        //各種要用的 function 寫在這
        create_user: function () {
            this.$http.post($ApiURL, vue.user).then(function (response) {
                console.log(response);
                location.href = "/demo";
            }, function (error) {
                console.log(error.statusText);
            });
        },
    },
    computed: {
        //計算屬性，好用，但此範例沒用到 XDD
    }
});