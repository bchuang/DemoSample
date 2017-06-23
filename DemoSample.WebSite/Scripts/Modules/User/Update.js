var $ApiURL = 'http://localhost/demo_api/api/User';
var acct = getQueryString('acct');
var vue = new Vue({
    el: '#app', //網頁最外層的 id，所有 vue 操控的部分，皆要寫在裡面
    data: {
        //網頁用到的資料都放在這
        user:
        {
            id: '',
            name: '',
            acct: ''
        },
        validated: {
            message: '',
            id: [],
            acct: [],
            name: [],
        },
    },
    created: function () {
        // 網頁載入完成，先執行的 function 內容寫在這(像 jQ 的 .ready())
        this.get_user();
    },
    methods: {
        //各種要用的 function 寫在這
        get_user: function () {
            this.$http.get($ApiURL, { params: { acct: acct } }).then(function (response) {
                vue.user = response.data.data;
            }, function (error) {
                console.log(error.statusText);
            });
        },

        update_user: function () {
            this.$http.put($ApiURL, vue.user).then(function (response) {
                location.href = "/demo";
            }, function (error) {
                vue.validated.message = error.body.message;
                vue.validated.id = error.body.modelState['user.id'];
                vue.validated.acct = error.body.modelState['user.Acct'];
                vue.validated.name = error.body.modelState['user.Name'];
                console.log(error.statusText);
            });
        },
    },
    computed: {
        //計算屬性，好用，但此範例沒用到 XDD
    }
});