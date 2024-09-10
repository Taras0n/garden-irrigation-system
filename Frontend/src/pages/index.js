import styles from "../styles/Index.module.scss";
import Status from "../components/Status/Status";
import Schedule from "../components/Schedule/Schedule";
import Sensors from "../components/Sensors/Sensors";
import Weather from "../components/Weather/Weather";
import Footer from "../components/Footer/Footer";
import Header from "../components/Header/Header"

const Index = () => {
    return (
        <>
            <section className={styles.dashboard}>
                <div className={styles.container}>
                    <div className={styles.status_system}>
                        <Status />
                    </div>
                    <div className={styles.watering_schedule}>
                        <Schedule />
                    </div>
                    <div className={styles.sensors}>
                        <Sensors />
                    </div>
                    <div className={styles.weather_forecast}>
                        <Weather />
                    </div>
                </div>
            </section>
        </>
    );
};

export default Index;
