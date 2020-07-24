// Vendor Files
import Vue from 'vue';
import Axios from 'axios';

// Base Files
import SignalRGlobal from './Base/Signalr/global';

// Home Page Vue
const Home = new Vue({
    el: '#home',
    // define methods under the `methods` object
    methods: {
        likeStatus: function (event) {
            var data = {
                userId: event.target.parentElement.querySelector('input[name="userId"]').value,
                postId: event.target.parentElement.querySelector('input[name="postId"]').value
            }

            if (event.target.classList.contains('post-liked')) {
                // Post has already been liked.
                data.liked = 1;
                data.url = 'UnlikePost';
            } else if (event.target.classList.contains('post-unliked')) {
                // Post hasn't already been liked.
                data.liked = 0;
                data.url = 'LikePost';
            }

            axios.post('/Ajax/' + data.url, data)
                .then(function (r) {
                    console.log(r);
                    if (data.response == "Success") {
                        event.target.removeClass('post-unliked').addClass('post-liked');
                        postLikesHtml($this, data);
                    }
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
    }
});