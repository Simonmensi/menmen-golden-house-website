import React from 'react';
import Link from '@docusaurus/Link';
import styles from './index.module.css';

const FeatureList = [
  {
    title: '高光时刻',
    description: <>捕捉与珍藏的美好时刻.</>,
    image: '/img/highlights-men.png',
    to: '/gallery',
  },
  {
    title: '音乐治愈一切',
    description: <>旋律与记忆的大门.</>,
    image: '/img/music-heals.png',
    href: 'https://www.taylorswift.com',
  },
  {
    title: '留言板',
    description: <>欢迎来提问与留言 ：）</>,
    image: '/img/guestbook.png',
    to: '/guestbook',
  },
];

function Card({ item }) {
  const body = (
    <div className={`${styles.card} card`}>
      {/* 改这里：用容器控制比例与圆角 */}
      <div className={styles.imageWrap}>
        <img
          src={item.image}
          alt={item.title}
          className={styles.imageContain}
        />
      </div>

      <div className="card__body">
        <h3>{item.title}</h3>
        {/* 加权重的 class，配合 CSS 里 !important */}
        <p className={styles.description}>{item.description}</p>
      </div>
    </div>
  );

  // ...下面保持不变


  if (item.to) {
    return (
      <Link to={item.to} className={styles.cardLink}>
        {body}
      </Link>
    );
  }
  if (item.href) {
    return (
      <a href={item.href} target="_blank" rel="noreferrer" className={styles.cardLink}>
        {body}
      </a>
    );
  }
  return body;
}

export default function HomepageFeatures() {
  return (
    <section className={styles.features}>
      <div className="container">
        <div className="row">
          {FeatureList.map((item, idx) => (
            <div key={idx} className="col col--4">
              <Card item={item} />
            </div>
          ))}
        </div>
      </div>
    </section>
  );
}
