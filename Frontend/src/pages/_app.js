// pages/_app.js
import '../styles/global.scss';  // Імпорт глобальних стилів

function MyApp({ Component, pageProps }) {
    return <Component {...pageProps} />;
}

export default MyApp;
