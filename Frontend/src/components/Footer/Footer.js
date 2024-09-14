import styles from "../Footer/Footer.module.scss"
const Footer = () => {
    return (
        <footer className={styles.footer}>
            <p>&copy; {new Date().getFullYear()} Moja strona. Wypierdalać.</p>
        </footer>
    );
};

export default Footer;